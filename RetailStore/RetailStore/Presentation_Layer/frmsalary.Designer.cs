namespace RetailStore.Presentation_Layer
{
    partial class frmSalary
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
            this.cmb_userId = new System.Windows.Forms.ComboBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lblinfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_userId
            // 
            this.cmb_userId.FormattingEnabled = true;
            this.cmb_userId.Location = new System.Drawing.Point(166, 23);
            this.cmb_userId.Name = "cmb_userId";
            this.cmb_userId.Size = new System.Drawing.Size(139, 21);
            this.cmb_userId.TabIndex = 1;
            // 
            // lbluserid
            // 
            this.lbluserid.Location = new System.Drawing.Point(68, 26);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(92, 18);
            this.lbluserid.TabIndex = 1;
            this.lbluserid.Text = "User name";
            // 
            // lblusername
            // 
            this.lblusername.Location = new System.Drawing.Point(69, 65);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(81, 17);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "User id";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(166, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblsalary
            // 
            this.lblsalary.Location = new System.Drawing.Point(69, 99);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(83, 20);
            this.lblsalary.TabIndex = 4;
            this.lblsalary.Text = "Enter salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(166, 99);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(139, 20);
            this.txtSalary.TabIndex = 3;
            // 
            // lbldate
            // 
            this.lbldate.Location = new System.Drawing.Point(69, 136);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(68, 19);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Select date";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(234, 233);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(58, 28);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(356, 233);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(65, 28);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(166, 136);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(139, 20);
            this.dtp_Date.TabIndex = 4;
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(268, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(192, 29);
            this.lblinfo.TabIndex = 7;
            this.lblinfo.Text = "Salary details\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.lblsalary);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Controls.Add(this.lbluserid);
            this.groupBox1.Controls.Add(this.cmb_userId);
            this.groupBox1.Location = new System.Drawing.Point(142, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary details";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(667, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Details";
            this.Load += new System.EventHandler(this.frmsalary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_userId;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}