namespace RetailStore.Presentation_Layer
{
    partial class frmListUsers
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.dgvSearchUsers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(235, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(133, 22);
            this.lblinfo.TabIndex = 2;
            this.lblinfo.Text = "Search Users";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.lbluserid);
            this.groupBox1.Location = new System.Drawing.Point(145, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(93, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(175, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "User Name";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(93, 30);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(175, 20);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(16, 35);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(41, 13);
            this.lbluserid.TabIndex = 0;
            this.lbluserid.Text = "User Id";
            // 
            // dgvSearchUsers
            // 
            this.dgvSearchUsers.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvSearchUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchUsers.Location = new System.Drawing.Point(23, 192);
            this.dgvSearchUsers.Name = "dgvSearchUsers";
            this.dgvSearchUsers.Size = new System.Drawing.Size(569, 222);
            this.dgvSearchUsers.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(467, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvSearchUsers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search users";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.DataGridView dgvSearchUsers;
        private System.Windows.Forms.Button btnClose;
    }
}