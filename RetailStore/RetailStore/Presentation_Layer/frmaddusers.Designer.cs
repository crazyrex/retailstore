namespace RetailStore.Presentation_Layer
{
    partial class frmAddUsers
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
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lbladdress3 = new System.Windows.Forms.Label();
            this.lbladdress2 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblcountry = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblstate = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblpin = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lbladdress1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(225, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(192, 23);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Add User Details";
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(22, 51);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(41, 13);
            this.lbluserid.TabIndex = 1;
            this.lbluserid.Text = "User Id";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(21, 73);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(63, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Enter Name";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(112, 44);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(112, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(170, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(21, 97);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(81, 13);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Enter Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(112, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(170, 20);
            this.txtPass.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress3);
            this.groupBox1.Controls.Add(this.txtAddress2);
            this.groupBox1.Controls.Add(this.lbladdress3);
            this.groupBox1.Controls.Add(this.lbladdress2);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.lblcountry);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.lblstate);
            this.groupBox1.Controls.Add(this.txtPin);
            this.groupBox1.Controls.Add(this.lblpin);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblcity);
            this.groupBox1.Controls.Add(this.txtAddress1);
            this.groupBox1.Controls.Add(this.lbladdress1);
            this.groupBox1.Location = new System.Drawing.Point(299, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(79, 75);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(190, 20);
            this.txtAddress3.TabIndex = 6;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(79, 47);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(190, 20);
            this.txtAddress2.TabIndex = 5;
            // 
            // lbladdress3
            // 
            this.lbladdress3.AutoSize = true;
            this.lbladdress3.Location = new System.Drawing.Point(20, 78);
            this.lbladdress3.Name = "lbladdress3";
            this.lbladdress3.Size = new System.Drawing.Size(36, 13);
            this.lbladdress3.TabIndex = 30;
            this.lbladdress3.Text = "Line 3";
            // 
            // lbladdress2
            // 
            this.lbladdress2.AutoSize = true;
            this.lbladdress2.Location = new System.Drawing.Point(19, 50);
            this.lbladdress2.Name = "lbladdress2";
            this.lbladdress2.Size = new System.Drawing.Size(36, 13);
            this.lbladdress2.TabIndex = 29;
            this.lbladdress2.Text = "Line 2";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(79, 191);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(190, 20);
            this.txtCountry.TabIndex = 10;
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Location = new System.Drawing.Point(21, 194);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(43, 13);
            this.lblcountry.TabIndex = 28;
            this.lblcountry.Text = "Country";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(79, 161);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(190, 20);
            this.txtState.TabIndex = 9;
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(20, 164);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(32, 13);
            this.lblstate.TabIndex = 26;
            this.lblstate.Text = "State";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(79, 132);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(190, 20);
            this.txtPin.TabIndex = 8;
            // 
            // lblpin
            // 
            this.lblpin.AutoSize = true;
            this.lblpin.Location = new System.Drawing.Point(20, 133);
            this.lblpin.Name = "lblpin";
            this.lblpin.Size = new System.Drawing.Size(50, 13);
            this.lblpin.TabIndex = 22;
            this.lblpin.Text = "Pin Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(79, 104);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(190, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(20, 105);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 13);
            this.lblcity.TabIndex = 20;
            this.lblcity.Text = "City";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(79, 21);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(190, 20);
            this.txtAddress1.TabIndex = 4;
            // 
            // lbladdress1
            // 
            this.lbladdress1.AutoSize = true;
            this.lbladdress1.Location = new System.Drawing.Point(19, 24);
            this.lbladdress1.Name = "lbladdress1";
            this.lbladdress1.Size = new System.Drawing.Size(36, 13);
            this.lbladdress1.TabIndex = 19;
            this.lbladdress1.Text = "Line 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(25, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 92);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other details";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email id";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(63, 19);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phone";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(52, 238);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 26);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(156, 238);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 26);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(24, 282);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(570, 147);
            this.dgvUsers.TabIndex = 15;
            // 
            // frmAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmAddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Users";
            this.Load += new System.EventHandler(this.frmAddUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblpin;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lbladdress1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbladdress3;
        private System.Windows.Forms.Label lbladdress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}