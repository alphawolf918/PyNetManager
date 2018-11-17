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
			this.lblSpeeds = new System.Windows.Forms.Label();
			this.lsSpeeds = new System.Windows.Forms.ListView();
			this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colUpload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDownload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnRunScript = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSpeeds
			// 
			this.lblSpeeds.AutoSize = true;
			this.lblSpeeds.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeeds.Location = new System.Drawing.Point(14, 22);
			this.lblSpeeds.Name = "lblSpeeds";
			this.lblSpeeds.Size = new System.Drawing.Size(167, 16);
			this.lblSpeeds.TabIndex = 0;
			this.lblSpeeds.Text = "Logged Network Speeds";
			// 
			// lsSpeeds
			// 
			this.lsSpeeds.BackColor = System.Drawing.SystemColors.Window;
			this.lsSpeeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lsSpeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colUpload,
            this.colDownload,
            this.colDate});
			this.lsSpeeds.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsSpeeds.GridLines = true;
			this.lsSpeeds.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lsSpeeds.HideSelection = false;
			this.lsSpeeds.Location = new System.Drawing.Point(14, 94);
			this.lsSpeeds.MultiSelect = false;
			this.lsSpeeds.Name = "lsSpeeds";
			this.lsSpeeds.Size = new System.Drawing.Size(674, 409);
			this.lsSpeeds.TabIndex = 1;
			this.lsSpeeds.UseCompatibleStateImageBehavior = false;
			this.lsSpeeds.View = System.Windows.Forms.View.Details;
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
			this.colDate.Width = 303;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(14, 59);
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
			this.btnRunScript.Location = new System.Drawing.Point(592, 59);
			this.btnRunScript.Name = "btnRunScript";
			this.btnRunScript.Size = new System.Drawing.Size(96, 29);
			this.btnRunScript.TabIndex = 3;
			this.btnRunScript.Text = "Run Script";
			this.btnRunScript.UseVisualStyleBackColor = true;
			this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 515);
			this.Controls.Add(this.btnRunScript);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.lsSpeeds);
			this.Controls.Add(this.lblSpeeds);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.ShowIcon = false;
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
	}
}

