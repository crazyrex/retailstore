namespace RetailStore.Presentation_Layer
{
    partial class frmTimesheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbluserid = new System.Windows.Forms.Label();
            this.cmbUserId = new System.Windows.Forms.ComboBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbluserid
            // 
            this.lbluserid.Location = new System.Drawing.Point(24, 25);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(86, 21);
            this.lbluserid.TabIndex = 0;
            this.lbluserid.Text = "Select user id";
            // 
            // cmbUserId
            // 
            this.cmbUserId.FormattingEnabled = true;
            this.cmbUserId.Location = new System.Drawing.Point(136, 22);
            this.cmbUserId.Name = "cmbUserId";
            this.cmbUserId.Size = new System.Drawing.Size(136, 21);
            this.cmbUserId.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.Location = new System.Drawing.Point(24, 87);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(100, 23);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(136, 83);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(136, 20);
            this.dtp_Date.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(136, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(136, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblusername
            // 
            this.lblusername.Location = new System.Drawing.Point(24, 56);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(84, 12);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "User name";
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.cmbUserId);
            this.Controls.Add(this.lbluserid);
            this.Name = "frmTimesheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Timesheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.ComboBox cmbUserId;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblusername;
    }
}