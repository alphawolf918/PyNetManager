using System;

namespace PyNetManager {
	partial class FrmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.lblSpeeds = new System.Windows.Forms.Label();
			this.lsSpeeds = new System.Windows.Forms.ListView();
			this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colUpload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDownload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnRunScript = new System.Windows.Forms.Button();
			this.lblDateRange = new System.Windows.Forms.Label();
			this.dtFrom = new System.Windows.Forms.DateTimePicker();
			this.dtTo = new System.Windows.Forms.DateTimePicker();
			this.sqlService = new System.ServiceProcess.ServiceController();
			this.SuspendLayout();
			// 
			// lblSpeeds
			// 
			this.lblSpeeds.AutoSize = true;
			this.lblSpeeds.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeeds.Location = new System.Drawing.Point(12, 9);
			this.lblSpeeds.Name = "lblSpeeds";
			this.lblSpeeds.Size = new System.Drawing.Size(167, 16);
			this.lblSpeeds.TabIndex = 0;
			this.lblSpeeds.Text = "Logged Network Speeds";
			// 
			// lsSpeeds
			// 
			this.lsSpeeds.BackColor = System.Drawing.SystemColors.Window;
			this.lsSpeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colUpload,
            this.colDownload,
            this.colNetName,
            this.colDate});
			this.lsSpeeds.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsSpeeds.FullRowSelect = true;
			this.lsSpeeds.GridLines = true;
			this.lsSpeeds.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lsSpeeds.HideSelection = false;
			this.lsSpeeds.Location = new System.Drawing.Point(11, 94);
			this.lsSpeeds.Name = "lsSpeeds";
			this.lsSpeeds.Size = new System.Drawing.Size(759, 409);
			this.lsSpeeds.TabIndex = 1;
			this.lsSpeeds.UseCompatibleStateImageBehavior = false;
			this.lsSpeeds.View = System.Windows.Forms.View.Details;
			this.lsSpeeds.DoubleClick += new System.EventHandler(this.ls_DoubleClick);
			// 
			// colID
			// 
			this.colID.Text = "ID";
			this.colID.Width = 43;
			// 
			// colUpload
			// 
			this.colUpload.Text = "Upload";
			this.colUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colUpload.Width = 116;
			// 
			// colDownload
			// 
			this.colDownload.Text = "Download";
			this.colDownload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colDownload.Width = 128;
			// 
			// colDate
			// 
			this.colDate.Text = "Date Logged";
			this.colDate.Width = 234;
			// 
			// colNetName
			// 
			this.colNetName.Text = "Network";
			this.colNetName.Width = 180;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(12, 59);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(96, 29);
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnRunScript
			// 
			this.btnRunScript.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRunScript.Location = new System.Drawing.Point(675, 59);
			this.btnRunScript.Name = "btnRunScript";
			this.btnRunScript.Size = new System.Drawing.Size(96, 29);
			this.btnRunScript.TabIndex = 3;
			this.btnRunScript.Text = "Run Script";
			this.btnRunScript.UseVisualStyleBackColor = true;
			this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
			// 
			// lblDateRange
			// 
			this.lblDateRange.AutoSize = true;
			this.lblDateRange.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateRange.Location = new System.Drawing.Point(319, 9);
			this.lblDateRange.Name = "lblDateRange";
			this.lblDateRange.Size = new System.Drawing.Size(144, 16);
			this.lblDateRange.TabIndex = 6;
			this.lblDateRange.Text = "Specify Date Range:";
			// 
			// dtFrom
			// 
			this.dtFrom.CustomFormat = "MMMMdd, yyyy";
			this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFrom.Location = new System.Drawing.Point(322, 29);
			this.dtFrom.Name = "dtFrom";
			this.dtFrom.Size = new System.Drawing.Size(221, 21);
			this.dtFrom.TabIndex = 7;
			this.dtFrom.Value = new System.DateTime(2018, 11, 11, 0, 0, 0, 0);
			this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
			// 
			// dtTo
			// 
			this.dtTo.CustomFormat = "MMMMdd, yyyy";
			this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtTo.Location = new System.Drawing.Point(549, 29);
			this.dtTo.MinDate = new System.DateTime(2018, 1, 11, 0, 0, 0, 0);
			this.dtTo.Name = "dtTo";
			this.dtTo.Size = new System.Drawing.Size(221, 21);
			this.dtTo.TabIndex = 8;
			this.dtTo.Value = new System.DateTime(2018, 11, 18, 0, 0, 0, 0);
			this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
			// 
			// sqlService
			// 
			//this.sqlService.ServiceName = "MSSQL$SQLEXPRESS01";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 515);
			this.Controls.Add(this.dtTo);
			this.Controls.Add(this.dtFrom);
			this.Controls.Add(this.lblDateRange);
			this.Controls.Add(this.btnRunScript);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.lsSpeeds);
			this.Controls.Add(this.lblSpeeds);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PyNet Manager";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSpeeds;
		private System.Windows.Forms.ListView lsSpeeds;
		private System.Windows.Forms.ColumnHeader colID;
		private System.Windows.Forms.ColumnHeader colUpload;
		private System.Windows.Forms.ColumnHeader colDownload;
		private System.Windows.Forms.ColumnHeader colDate;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnRunScript;
		private System.Windows.Forms.Label lblDateRange;
		private System.Windows.Forms.DateTimePicker dtFrom;
		private System.Windows.Forms.DateTimePicker dtTo;
		public System.ServiceProcess.ServiceController sqlService;
		private System.Windows.Forms.ColumnHeader colNetName;
	}
}

