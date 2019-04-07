using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;
using IniParser; //Installed Ini-Parser with NuGet
using IniParser.Model; //Installed Ini-Parser with NuGet

namespace PyNetManager {

	public partial class FrmMain : Form {

		private const string conErrorStr = "Could not establish database connection: \n\n";

		string confSection = "DEFAULT";
		string sqlDataSrc;
		string sqlDb;

		int startMonth;
		int startDay;
		int startYear;

		public FrmMain() => InitializeComponent();

		private void FrmMain_Load(object sender, EventArgs e) {
			FileIniDataParser parser = new FileIniDataParser();
			IniData data = parser.ReadFile(filePath: Directory.GetCurrentDirectory() + @"\config.ini");

			sqlService.ServiceName = data[confSection]["Service"];
			sqlDataSrc = data[confSection]["Server"];
			sqlDb = data[confSection]["Database"];

			startMonth = CInt(data[confSection]["StartMonth"]);
			startDay = CInt(data[confSection]["StartDay"]);
			startYear = CInt(data[confSection]["StartYear"]);

			if (sqlService.Status == ServiceControllerStatus.Stopped) {
				sqlService.Start();
			}

			PopulateListView();
			SizeLastColumn(lv: lsSpeeds);
			dtFrom.Value = new DateTime(startYear, startMonth, startDay);
			dtTo.Value = DateTime.Today.AddDays(1.0D);
		}

		private void PopulateListView() {
			SqlConnection sqlCon = new SqlConnection(@"Data Source=" + sqlDataSrc + ";" +
													  "Initial Catalog=" + sqlDb + ";" +
													  "Trusted_Connection=yes;");
			string strSQL = "SELECT ID," +
							"       Upload," +
							"       Download," +
							"       Network," +
							"       DateLogged " +
							"FROM view_net_speeds " +
							"WHERE DateLogged BETWEEN CONVERT(datetime, '" + dtFrom.Value + "') " +
							"AND CONVERT(datetime, '" + dtTo.Value + "') " +
							"ORDER BY ID DESC;";
		Connect:
			try {
				sqlCon.Open();
				SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, sqlCon);
				DataSet dataSet = new DataSet();
				sqlData.Fill(dataSet, "view_net_speeds");
				sqlCon.Close();

				DataTable dataTbl = dataSet.Tables[0];
				int i = 0;
				foreach (DataRow row in dataTbl.Rows) {
					ListViewItem viewItem = new ListViewItem {
						Text = CStr(row["ID"])
					};
					viewItem.SubItems.Add(CStr(row["Upload"]));
					viewItem.SubItems.Add(CStr(row["Download"]));
					viewItem.SubItems.Add(CStr(row["Network"]).Replace(" ", ""));
					viewItem.SubItems.Add(CStr(row["DateLogged"]));
					lsSpeeds.Items.Add(value: viewItem);
					if (i % 2 == 0) {
						viewItem.BackColor = SystemColors.Menu;
					}
					i++;
				}
			} catch (SqlException ex) {
				DialogResult msgRes = MessageBox.Show(conErrorStr + ex.Message, "Connection Error", MessageBoxButtons.AbortRetryIgnore);
				if (msgRes == DialogResult.Retry) {
					goto Connect;
				} else if (msgRes == DialogResult.Ignore) {
					goto End;
				} else {
					Environment.Exit(1);
				}
			}
		End:
			;
		}

		private void RemoveAll() {
			foreach (ListViewItem viewItem in lsSpeeds.Items) {
				lsSpeeds.Items.Remove(viewItem);
			}
		}

		private void btnRunScript_Click(object sender, EventArgs e) {
			ProcessStartInfo procInfo = new ProcessStartInfo(@"C:\Tasks\PyNet.py");
			Process proc = Process.Start(procInfo);
			proc.WaitForExit();
			RefreshList();
		}

		private void ls_DoubleClick(object sender, EventArgs e) {
			//TODO
		}

		private void RefreshList() {
			RemoveAll();
			PopulateListView();
		}

		private string CStr(object value) => Convert.ToString(value);
		private int CInt(object value) => Convert.ToInt32(value);
		private void SizeLastColumn(ListView lv) => lv.Columns[lv.Columns.Count - 1].Width = -2;
		private void btnRefresh_Click(object sender, EventArgs e) => RefreshList();
		private void dtFrom_ValueChanged(object sender, EventArgs e) => RefreshList();
		private void dtTo_ValueChanged(object sender, EventArgs e) => RefreshList();

	}
}