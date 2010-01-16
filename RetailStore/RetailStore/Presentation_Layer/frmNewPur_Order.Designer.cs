namespace RetailStore.Presentation_Layer
{
    partial class frmNewPur_Order
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbVenName = new System.Windows.Forms.ComboBox();
            this.dtp_Req_Date = new System.Windows.Forms.DateTimePicker();
            this.lblreqdate = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblvenid = new System.Windows.Forms.Label();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.lblpurcid = new System.Windows.Forms.Label();
            this.dgvPOItems = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(208, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(199, 23);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "New Purchase Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbVenName);
            this.groupBox1.Controls.Add(this.dtp_Req_Date);
            this.groupBox1.Controls.Add(this.lblreqdate);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblvenid);
            this.groupBox1.Controls.Add(this.txtPurchaseId);
            this.groupBox1.Controls.Add(this.lblpurcid);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(503, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbVenName
            // 
            this.cmbVenName.FormattingEnabled = true;
            this.cmbVenName.Location = new System.Drawing.Point(362, 24);
            this.cmbVenName.Name = "cmbVenName";
            this.cmbVenName.Size = new System.Drawing.Size(127, 21);
            this.cmbVenName.TabIndex = 3;
            // 
            // dtp_Req_Date
            // 
            this.dtp_Req_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Req_Date.Location = new System.Drawing.Point(362, 61);
            this.dtp_Req_Date.Name = "dtp_Req_Date";
            this.dtp_Req_Date.Size = new System.Drawing.Size(127, 20);
            this.dtp_Req_Date.TabIndex = 4;
            // 
            // lblreqdate
            // 
            this.lblreqdate.AutoSize = true;
            this.lblreqdate.Location = new System.Drawing.Point(272, 65);
            this.lblreqdate.Name = "lblreqdate";
            this.lblreqdate.Size = new System.Drawing.Size(76, 13);
            this.lblreqdate.TabIndex = 6;
            this.lblreqdate.Text = "Required Date\r\n";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(15, 61);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(59, 13);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Order Date";
            // 
            // lblvenid
            // 
            this.lblvenid.AutoSize = true;
            this.lblvenid.Location = new System.Drawing.Point(274, 26);
            this.lblvenid.Name = "lblvenid";
            this.lblvenid.Size = new System.Drawing.Size(72, 13);
            this.lblvenid.TabIndex = 2;
            this.lblvenid.Text = "Vendor Name";
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Location = new System.Drawing.Point(108, 24);
            this.txtPurchaseId.MaxLength = 6;
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(126, 20);
            this.txtPurchaseId.TabIndex = 1;
            // 
            // lblpurcid
            // 
            this.lblpurcid.AutoSize = true;
            this.lblpurcid.Location = new System.Drawing.Point(15, 26);
            this.lblpurcid.Name = "lblpurcid";
            this.lblpurcid.Size = new System.Drawing.Size(45, 13);
            this.lblpurcid.TabIndex = 0;
            this.lblpurcid.Text = "Order Id";
            // 
            // dgvPOItems
            // 
            this.dgvPOItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPOItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.productDescription,
            this.qty,
            this.price,
            this.subtotal});
            this.dgvPOItems.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPOItems.Location = new System.Drawing.Point(12, 154);
            this.dgvPOItems.Name = "dgvPOItems";
            this.dgvPOItems.Size = new System.Drawing.Size(593, 164);
            this.dgvPOItems.TabIndex = 11;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(371, 331);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(36, 13);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(460, 328);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(386, 379);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 25);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(515, 379);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 25);
            this.btnprint.TabIndex = 7;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(30, 379);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ProductID
            // 
            this.ProductID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProductID.DisplayStyleForCurrentCellOnly = true;
            this.ProductID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productDescription
            // 
            this.productDescription.HeaderText = "Product Description";
            this.productDescription.Name = "productDescription";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Amount";
            this.subtotal.Name = "subtotal";
            // 
            // frmNewPur_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgvPOItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmNewPur_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Purchase Order";
            this.Load += new System.EventHandler(this.frmNewPur_Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblpurcid;
        private System.Windows.Forms.Label lblvenid;
        private System.Windows.Forms.TextBox txtPurchaseId;
        private System.Windows.Forms.Label lblreqdate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dtp_Req_Date;
        private System.Windows.Forms.DataGridView dgvPOItems;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbVenName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}