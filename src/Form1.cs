using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PyNetManager {
	public partial class FrmMain : Form {

		public FrmMain() => InitializeComponent();

		private void FrmMain_Load(object sender, EventArgs e) {
			PopulateListView();
			SizeLastColumn(lv: lsSpeeds);
			dtFrom.Value = new DateTime(2018, 11, 11);
			dtTo.Value = DateTime.Today;
		}

		private void PopulateListView() {
			SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=PyNet;
										 Trusted_Connection=yes;");
			string strSQL = "SELECT * FROM view_net_speeds " +
							"WHERE DateLogged BETWEEN '" + dtFrom.Value + "' AND '" + dtTo.Value + "' " +
							"ORDER BY ID DESC;";
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
							Text = Convert.ToString(row["ID"])
						};
						viewItem.SubItems.Add(text: Convert.ToString(row["Upload"]));
						viewItem.SubItems.Add(text: Convert.ToString(row["Download"]));
						viewItem.SubItems.Add(text: Convert.ToString(row["DateLogged"]));
						lsSpeeds.Items.Add(value: viewItem);
						if (i % 2 == 0) {
							viewItem.BackColor = SystemColors.Menu;
						}
						i++;
					}
			} catch (Exception ex) {
				Console.WriteLine(ex.StackTrace);
			}
		}

		private void RemoveAll() {
			foreach (ListViewItem viewItem in lsSpeeds.Items) {
				lsSpeeds.Items.Remove(viewItem);
			}
		}

		private void SizeLastColumn(ListView lv) => lv.Columns[lv.Columns.Count - 1].Width = -2;

		private void btnRunScript_Click(object sender, EventArgs e) {
			ProcessStartInfo procInfo = new ProcessStartInfo(@"C:\Tasks\PyNet.py");
			Process proc = Process.Start(procInfo);
			proc.WaitForExit();
			RefreshList();
		}

		private void RefreshList() {
			RemoveAll();
			PopulateListView();
		}
		
		private void btnRefresh_Click(object sender, EventArgs e) => RefreshList();
		private void dtFrom_ValueChanged(object sender, EventArgs e) => RefreshList();
		private void dtTo_ValueChanged(object sender, EventArgs e) => RefreshList();
	}
}