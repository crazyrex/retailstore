namespace RetailStore.Presentation_Layer
{
    partial class frmAddProducts
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
            this.lblprodid = new System.Windows.Forms.Label();
            this.lblprodname = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblattri = new System.Windows.Forms.Label();
            this.txtProdAttribute = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblquan = new System.Windows.Forms.Label();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblpurchaseprice = new System.Windows.Forms.Label();
            this.txtPurcPrice = new System.Windows.Forms.TextBox();
            this.lblsellingprice = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpUpdated = new System.Windows.Forms.DateTimePicker();
            this.cmbWarehouseId = new System.Windows.Forms.ComboBox();
            this.lblWhid = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblReorderqty = new System.Windows.Forms.Label();
            this.lblReorderlevel = new System.Windows.Forms.Label();
            this.txtReorderQty = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(224, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(208, 23);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Add Product Details\r\n";
            // 
            // lblprodid
            // 
            this.lblprodid.Location = new System.Drawing.Point(17, 24);
            this.lblprodid.Name = "lblprodid";
            this.lblprodid.Size = new System.Drawing.Size(74, 19);
            this.lblprodid.TabIndex = 1;
            this.lblprodid.Text = "Product Id";
            // 
            // lblprodname
            // 
            this.lblprodname.AutoSize = true;
            this.lblprodname.Location = new System.Drawing.Point(17, 50);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(63, 13);
            this.lblprodname.TabIndex = 2;
            this.lblprodname.Text = "Enter Name";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(107, 21);
            this.txtProdId.MaxLength = 6;
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(174, 20);
            this.txtProdId.TabIndex = 1;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(107, 47);
            this.txtProdName.MaxLength = 255;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(174, 20);
            this.txtProdName.TabIndex = 2;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            // 
            // lblattri
            // 
            this.lblattri.AutoSize = true;
            this.lblattri.Location = new System.Drawing.Point(21, 123);
            this.lblattri.Name = "lblattri";
            this.lblattri.Size = new System.Drawing.Size(51, 13);
            this.lblattri.TabIndex = 5;
            this.lblattri.Text = "Attributes";
            // 
            // txtProdAttribute
            // 
            this.txtProdAttribute.Location = new System.Drawing.Point(107, 121);
            this.txtProdAttribute.MaxLength = 255;
            this.txtProdAttribute.Name = "txtProdAttribute";
            this.txtProdAttribute.Size = new System.Drawing.Size(174, 20);
            this.txtProdAttribute.TabIndex = 3;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(18, 76);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(60, 13);
            this.lbldesc.TabIndex = 7;
            this.lbldesc.Text = "Description\r\n";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(107, 73);
            this.txtDesc.MaxLength = 1000;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(174, 42);
            this.txtDesc.TabIndex = 5;
            // 
            // lblquan
            // 
            this.lblquan.AutoSize = true;
            this.lblquan.Location = new System.Drawing.Point(7, 51);
            this.lblquan.Name = "lblquan";
            this.lblquan.Size = new System.Drawing.Size(46, 13);
            this.lblquan.TabIndex = 10;
            this.lblquan.Text = "Quantity";
            // 
            // txtProdQty
            // 
            this.txtProdQty.Location = new System.Drawing.Point(89, 50);
            this.txtProdQty.MaxLength = 7;
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(174, 20);
            this.txtProdQty.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(58, 225);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 26);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(184, 225);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 26);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblpurchaseprice
            // 
            this.lblpurchaseprice.AutoSize = true;
            this.lblpurchaseprice.Location = new System.Drawing.Point(7, 155);
            this.lblpurchaseprice.Name = "lblpurchaseprice";
            this.lblpurchaseprice.Size = new System.Drawing.Size(79, 13);
            this.lblpurchaseprice.TabIndex = 11;
            this.lblpurchaseprice.Text = "Purchase Price";
            // 
            // txtPurcPrice
            // 
            this.txtPurcPrice.Location = new System.Drawing.Point(89, 155);
            this.txtPurcPrice.MaxLength = 10;
            this.txtPurcPrice.Name = "txtPurcPrice";
            this.txtPurcPrice.Size = new System.Drawing.Size(174, 20);
            this.txtPurcPrice.TabIndex = 6;
            // 
            // lblsellingprice
            // 
            this.lblsellingprice.AutoSize = true;
            this.lblsellingprice.Location = new System.Drawing.Point(7, 181);
            this.lblsellingprice.Name = "lblsellingprice";
            this.lblsellingprice.Size = new System.Drawing.Size(65, 13);
            this.lblsellingprice.TabIndex = 13;
            this.lblsellingprice.Text = "Selling Price";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(89, 181);
            this.txtSellPrice.MaxLength = 10;
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(174, 20);
            this.txtSellPrice.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.lbldesc);
            this.groupBox1.Controls.Add(this.txtProdName);
            this.groupBox1.Controls.Add(this.txtProdId);
            this.groupBox1.Controls.Add(this.lblprodname);
            this.groupBox1.Controls.Add(this.lblprodid);
            this.groupBox1.Controls.Add(this.txtProdAttribute);
            this.groupBox1.Controls.Add(this.lblattri);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 149);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpUpdated);
            this.groupBox2.Controls.Add(this.cmbWarehouseId);
            this.groupBox2.Controls.Add(this.lblWhid);
            this.groupBox2.Controls.Add(this.lblUpdated);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.lblReorderqty);
            this.groupBox2.Controls.Add(this.lblReorderlevel);
            this.groupBox2.Controls.Add(this.txtReorderQty);
            this.groupBox2.Controls.Add(this.txtReorderLevel);
            this.groupBox2.Controls.Add(this.txtProdQty);
            this.groupBox2.Controls.Add(this.lblsellingprice);
            this.groupBox2.Controls.Add(this.lblquan);
            this.groupBox2.Controls.Add(this.txtSellPrice);
            this.groupBox2.Controls.Add(this.lblpurchaseprice);
            this.groupBox2.Controls.Add(this.txtPurcPrice);
            this.groupBox2.Location = new System.Drawing.Point(326, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 237);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other details";
            // 
            // dtpUpdated
            // 
            this.dtpUpdated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdated.Location = new System.Drawing.Point(89, 207);
            this.dtpUpdated.Name = "dtpUpdated";
            this.dtpUpdated.Size = new System.Drawing.Size(174, 20);
            this.dtpUpdated.TabIndex = 24;
            // 
            // cmbWarehouseId
            // 
            this.cmbWarehouseId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouseId.FormattingEnabled = true;
            this.cmbWarehouseId.Location = new System.Drawing.Point(89, 24);
            this.cmbWarehouseId.MaxLength = 6;
            this.cmbWarehouseId.Name = "cmbWarehouseId";
            this.cmbWarehouseId.Size = new System.Drawing.Size(174, 21);
            this.cmbWarehouseId.TabIndex = 23;
            // 
            // lblWhid
            // 
            this.lblWhid.AutoSize = true;
            this.lblWhid.Location = new System.Drawing.Point(7, 27);
            this.lblWhid.Name = "lblWhid";
            this.lblWhid.Size = new System.Drawing.Size(62, 13);
            this.lblWhid.TabIndex = 22;
            this.lblWhid.Text = "Warehouse";
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Location = new System.Drawing.Point(7, 206);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(48, 13);
            this.lblUpdated.TabIndex = 20;
            this.lblUpdated.Text = "Updated";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 131);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(89, 128);
            this.txtStatus.MaxLength = 255;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(174, 20);
            this.txtStatus.TabIndex = 18;
            // 
            // lblReorderqty
            // 
            this.lblReorderqty.AutoSize = true;
            this.lblReorderqty.Location = new System.Drawing.Point(7, 105);
            this.lblReorderqty.Name = "lblReorderqty";
            this.lblReorderqty.Size = new System.Drawing.Size(64, 13);
            this.lblReorderqty.TabIndex = 17;
            this.lblReorderqty.Text = "Reorder Qty";
            // 
            // lblReorderlevel
            // 
            this.lblReorderlevel.AutoSize = true;
            this.lblReorderlevel.Location = new System.Drawing.Point(7, 79);
            this.lblReorderlevel.Name = "lblReorderlevel";
            this.lblReorderlevel.Size = new System.Drawing.Size(74, 13);
            this.lblReorderlevel.TabIndex = 16;
            this.lblReorderlevel.Text = "Reorder Level";
            // 
            // txtReorderQty
            // 
            this.txtReorderQty.Location = new System.Drawing.Point(89, 102);
            this.txtReorderQty.MaxLength = 7;
            this.txtReorderQty.Name = "txtReorderQty";
            this.txtReorderQty.Size = new System.Drawing.Size(174, 20);
            this.txtReorderQty.TabIndex = 15;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(89, 76);
            this.txtReorderLevel.MaxLength = 7;
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(174, 20);
            this.txtReorderLevel.TabIndex = 14;
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(22, 287);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(583, 142);
            this.dgvProduct.TabIndex = 17;
            // 
            // frmAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmAddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblprodid;
        private System.Windows.Forms.Label lblprodname;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblattri;
        private System.Windows.Forms.TextBox txtProdAttribute;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblquan;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblpurchaseprice;
        private System.Windows.Forms.TextBox txtPurcPrice;
        private System.Windows.Forms.Label lblsellingprice;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblReorderqty;
        private System.Windows.Forms.Label lblReorderlevel;
        private System.Windows.Forms.TextBox txtReorderQty;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Label lblWhid;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cmbWarehouseId;
        private System.Windows.Forms.DateTimePicker dtpUpdated;
    }
}