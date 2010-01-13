namespace RetailStore.Presentation_Layer
{
    partial class frmWarehouse_Details
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
            this.lblwhid = new System.Windows.Forms.Label();
            this.txtWarehouseId = new System.Windows.Forms.TextBox();
            this.lblwhname = new System.Windows.Forms.Label();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.lblcapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
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
            this.dgvWarehouse = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(176, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(255, 23);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "Add warehouse details here";
            // 
            // lblwhid
            // 
            this.lblwhid.AutoSize = true;
            this.lblwhid.Location = new System.Drawing.Point(15, 56);
            this.lblwhid.Name = "lblwhid";
            this.lblwhid.Size = new System.Drawing.Size(73, 13);
            this.lblwhid.TabIndex = 2;
            this.lblwhid.Text = "Warehouse id";
            // 
            // txtWarehouseId
            // 
            this.txtWarehouseId.Location = new System.Drawing.Point(117, 51);
            this.txtWarehouseId.Name = "txtWarehouseId";
            this.txtWarehouseId.Size = new System.Drawing.Size(170, 20);
            this.txtWarehouseId.TabIndex = 1;
            // 
            // lblwhname
            // 
            this.lblwhname.AutoSize = true;
            this.lblwhname.Location = new System.Drawing.Point(15, 88);
            this.lblwhname.Name = "lblwhname";
            this.lblwhname.Size = new System.Drawing.Size(91, 13);
            this.lblwhname.TabIndex = 4;
            this.lblwhname.Text = "Warehouse name";
            this.lblwhname.Click += new System.EventHandler(this.lblwhname_Click);
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(117, 84);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(170, 20);
            this.txtWarehouseName.TabIndex = 2;
            // 
            // lblcapacity
            // 
            this.lblcapacity.AutoSize = true;
            this.lblcapacity.Location = new System.Drawing.Point(16, 121);
            this.lblcapacity.Name = "lblcapacity";
            this.lblcapacity.Size = new System.Drawing.Size(48, 13);
            this.lblcapacity.TabIndex = 7;
            this.lblcapacity.Text = "Capacity";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(117, 117);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(170, 20);
            this.txtCapacity.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(50, 168);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 26);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(180, 168);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 26);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(308, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 228);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(79, 74);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(190, 20);
            this.txtAddress3.TabIndex = 6;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(79, 46);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(190, 20);
            this.txtAddress2.TabIndex = 5;
            // 
            // lbladdress3
            // 
            this.lbladdress3.AutoSize = true;
            this.lbladdress3.Location = new System.Drawing.Point(19, 75);
            this.lbladdress3.Name = "lbladdress3";
            this.lbladdress3.Size = new System.Drawing.Size(36, 13);
            this.lbladdress3.TabIndex = 30;
            this.lbladdress3.Text = "Line 3";
            // 
            // lbladdress2
            // 
            this.lbladdress2.AutoSize = true;
            this.lbladdress2.Location = new System.Drawing.Point(18, 49);
            this.lbladdress2.Name = "lbladdress2";
            this.lbladdress2.Size = new System.Drawing.Size(36, 13);
            this.lbladdress2.TabIndex = 29;
            this.lbladdress2.Text = "Line 2";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(79, 194);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(190, 20);
            this.txtCountry.TabIndex = 10;
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Location = new System.Drawing.Point(22, 196);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(43, 13);
            this.lblcountry.TabIndex = 28;
            this.lblcountry.Text = "Country";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(79, 164);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(190, 20);
            this.txtState.TabIndex = 9;
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(21, 166);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(32, 13);
            this.lblstate.TabIndex = 26;
            this.lblstate.Text = "State";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(79, 133);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(190, 20);
            this.txtPin.TabIndex = 8;
            // 
            // lblpin
            // 
            this.lblpin.AutoSize = true;
            this.lblpin.Location = new System.Drawing.Point(20, 135);
            this.lblpin.Name = "lblpin";
            this.lblpin.Size = new System.Drawing.Size(49, 13);
            this.lblpin.TabIndex = 22;
            this.lblpin.Text = "Pin code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(79, 103);
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
            this.txtAddress1.Location = new System.Drawing.Point(79, 18);
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
            // dgvWarehouse
            // 
            this.dgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse.Location = new System.Drawing.Point(12, 279);
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.Size = new System.Drawing.Size(591, 150);
            this.dgvWarehouse.TabIndex = 13;
            // 
            // frmWarehouse_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.dgvWarehouse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblcapacity);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.lblwhname);
            this.Controls.Add(this.txtWarehouseId);
            this.Controls.Add(this.lblwhid);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmWarehouse_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblwhid;
        private System.Windows.Forms.TextBox txtWarehouseId;
        private System.Windows.Forms.Label lblwhname;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label lblcapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lbladdress3;
        private System.Windows.Forms.Label lbladdress2;
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
        private System.Windows.Forms.DataGridView dgvWarehouse;
    }
}