namespace RetailStore.Presentation_Layer
{
    partial class frmAddCustomers
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
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(200, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(242, 23);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Add Customer Details\r\n";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Location = new System.Drawing.Point(22, 50);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(63, 13);
            this.lblcustid.TabIndex = 1;
            this.lblcustid.Text = "Customer Id";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Location = new System.Drawing.Point(23, 74);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(63, 13);
            this.lblcustname.TabIndex = 2;
            this.lblcustname.Text = "Enter Name";
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(96, 43);
            this.txtCustId.MaxLength = 6;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(166, 20);
            this.txtCustId.TabIndex = 1;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(97, 71);
            this.txtCustName.MaxLength = 255;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(165, 20);
            this.txtCustName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddress3);
            this.groupBox1.Controls.Add(this.lblAddress2);
            this.groupBox1.Controls.Add(this.txtAddress3);
            this.groupBox1.Controls.Add(this.txtAddress2);
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
            this.groupBox1.Location = new System.Drawing.Point(302, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Location = new System.Drawing.Point(16, 79);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(36, 13);
            this.lblAddress3.TabIndex = 22;
            this.lblAddress3.Text = "Line 3";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(16, 51);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(36, 13);
            this.lblAddress2.TabIndex = 21;
            this.lblAddress2.Text = "Line 2";
            this.lblAddress2.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(79, 73);
            this.txtAddress3.MaxLength = 255;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(188, 20);
            this.txtAddress3.TabIndex = 5;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(79, 47);
            this.txtAddress2.MaxLength = 255;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(188, 20);
            this.txtAddress2.TabIndex = 4;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(79, 180);
            this.txtCountry.MaxLength = 255;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(188, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Location = new System.Drawing.Point(19, 185);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(43, 13);
            this.lblcountry.TabIndex = 18;
            this.lblcountry.Text = "Country";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(79, 153);
            this.txtState.MaxLength = 255;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(188, 20);
            this.txtState.TabIndex = 8;
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(19, 159);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(32, 13);
            this.lblstate.TabIndex = 16;
            this.lblstate.Text = "State";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(79, 126);
            this.txtPin.MaxLength = 6;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(188, 20);
            this.txtPin.TabIndex = 7;
            // 
            // lblpin
            // 
            this.lblpin.AutoSize = true;
            this.lblpin.Location = new System.Drawing.Point(18, 131);
            this.lblpin.Name = "lblpin";
            this.lblpin.Size = new System.Drawing.Size(50, 13);
            this.lblpin.TabIndex = 12;
            this.lblpin.Text = "Pin Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(79, 100);
            this.txtCity.MaxLength = 255;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(188, 20);
            this.txtCity.TabIndex = 6;
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(17, 105);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 13);
            this.lblcity.TabIndex = 10;
            this.lblcity.Text = "City";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(79, 19);
            this.txtAddress1.MaxLength = 255;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(188, 20);
            this.txtAddress1.TabIndex = 3;
            // 
            // lbladdress1
            // 
            this.lbladdress1.AutoSize = true;
            this.lbladdress1.Location = new System.Drawing.Point(15, 22);
            this.lbladdress1.Name = "lbladdress1";
            this.lbladdress1.Size = new System.Drawing.Size(36, 13);
            this.lbladdress1.TabIndex = 9;
            this.lbladdress1.Text = "Line 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other details";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 55);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email Id";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(70, 20);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(60, 228);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 25);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(178, 228);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 25);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(25, 282);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(570, 147);
            this.dgvCustomers.TabIndex = 15;
            // 
            // frmAddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmAddCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customers";
            this.Load += new System.EventHandler(this.frmAddCustomers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtCountry;
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
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}