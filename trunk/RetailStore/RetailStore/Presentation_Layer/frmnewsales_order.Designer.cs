namespace RetailStore
{
    partial class frmnewsales_order
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
            this.cmbCusId = new System.Windows.Forms.ComboBox();
            this.dtp_Req_Date = new System.Windows.Forms.DateTimePicker();
            this.lblreqdate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblvenid = new System.Windows.Forms.Label();
            this.txtSalesId = new System.Windows.Forms.TextBox();
            this.lblsalesid = new System.Windows.Forms.Label();
            this.dgvSOItems = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSOItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(216, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(259, 23);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "New Sales Order";
            this.lblinfo.Click += new System.EventHandler(this.lblinfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCusId);
            this.groupBox1.Controls.Add(this.dtp_Req_Date);
            this.groupBox1.Controls.Add(this.lblreqdate);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblvenid);
            this.groupBox1.Controls.Add(this.txtSalesId);
            this.groupBox1.Controls.Add(this.lblsalesid);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // cmbCusId
            // 
            this.cmbCusId.FormattingEnabled = true;
            this.cmbCusId.Location = new System.Drawing.Point(424, 24);
            this.cmbCusId.Name = "cmbCusId";
            this.cmbCusId.Size = new System.Drawing.Size(121, 21);
            this.cmbCusId.TabIndex = 3;
            // 
            // dtp_Req_Date
            // 
            this.dtp_Req_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Req_Date.Location = new System.Drawing.Point(424, 62);
            this.dtp_Req_Date.Name = "dtp_Req_Date";
            this.dtp_Req_Date.Size = new System.Drawing.Size(121, 20);
            this.dtp_Req_Date.TabIndex = 4;
            // 
            // lblreqdate
            // 
            this.lblreqdate.AutoSize = true;
            this.lblreqdate.Location = new System.Drawing.Point(306, 65);
            this.lblreqdate.Name = "lblreqdate";
            this.lblreqdate.Size = new System.Drawing.Size(76, 13);
            this.lblreqdate.TabIndex = 6;
            this.lblreqdate.Text = "Required Date\r\n";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(105, 59);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(140, 20);
            this.txtDate.TabIndex = 2;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(15, 61);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(69, 13);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Present Date";
            // 
            // lblvenid
            // 
            this.lblvenid.AutoSize = true;
            this.lblvenid.Location = new System.Drawing.Point(306, 26);
            this.lblvenid.Name = "lblvenid";
            this.lblvenid.Size = new System.Drawing.Size(82, 13);
            this.lblvenid.TabIndex = 2;
            this.lblvenid.Text = "Customer Name";
            // 
            // txtSalesId
            // 
            this.txtSalesId.Location = new System.Drawing.Point(105, 24);
            this.txtSalesId.Name = "txtSalesId";
            this.txtSalesId.Size = new System.Drawing.Size(140, 20);
            this.txtSalesId.TabIndex = 1;
            // 
            // lblsalesid
            // 
            this.lblsalesid.AutoSize = true;
            this.lblsalesid.Location = new System.Drawing.Point(15, 26);
            this.lblsalesid.Name = "lblsalesid";
            this.lblsalesid.Size = new System.Drawing.Size(45, 13);
            this.lblsalesid.TabIndex = 0;
            this.lblsalesid.Text = "Order Id";
            // 
            // dgvSOItems
            // 
            this.dgvSOItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSOItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSOItems.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSOItems.Location = new System.Drawing.Point(12, 154);
            this.dgvSOItems.Name = "dgvSOItems";
            this.dgvSOItems.Size = new System.Drawing.Size(587, 164);
            this.dgvSOItems.TabIndex = 11;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(12, 380);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 25);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(385, 339);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(36, 13);
            this.lbltotal.TabIndex = 9;
            this.lbltotal.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(459, 332);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(140, 20);
            this.txttotal.TabIndex = 10;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(388, 381);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 25);
            this.btnconfirm.TabIndex = 6;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(524, 381);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 25);
            this.btnprint.TabIndex = 7;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // frmnewsales_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dgvSOItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmnewsales_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sales Order";
            this.Load += new System.EventHandler(this.frmnewsales_order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSOItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCusId;
        private System.Windows.Forms.DateTimePicker dtp_Req_Date;
        private System.Windows.Forms.Label lblreqdate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblvenid;
        private System.Windows.Forms.TextBox txtSalesId;
        private System.Windows.Forms.Label lblsalesid;
        private System.Windows.Forms.DataGridView dgvSOItems;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnprint;
    }
}