namespace RetailStore.Presentation_Layer
{
    partial class frmListProducts
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
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.lblProdname = new System.Windows.Forms.Label();
            this.lblProdid = new System.Windows.Forms.Label();
            this.dgvSearchProducts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(219, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(154, 22);
            this.lblinfo.TabIndex = 2;
            this.lblinfo.Text = "Search Products";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProdName);
            this.groupBox1.Controls.Add(this.txtProdId);
            this.groupBox1.Controls.Add(this.lblProdname);
            this.groupBox1.Controls.Add(this.lblProdid);
            this.groupBox1.Location = new System.Drawing.Point(147, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(101, 61);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(164, 20);
            this.txtProdName.TabIndex = 2;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(101, 25);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(164, 20);
            this.txtProdId.TabIndex = 1;
            this.txtProdId.TextChanged += new System.EventHandler(this.txtProdId_TextChanged);
            // 
            // lblProdname
            // 
            this.lblProdname.AutoSize = true;
            this.lblProdname.Location = new System.Drawing.Point(19, 64);
            this.lblProdname.Name = "lblProdname";
            this.lblProdname.Size = new System.Drawing.Size(75, 13);
            this.lblProdname.TabIndex = 1;
            this.lblProdname.Text = "Product Name";
            // 
            // lblProdid
            // 
            this.lblProdid.AutoSize = true;
            this.lblProdid.Location = new System.Drawing.Point(19, 28);
            this.lblProdid.Name = "lblProdid";
            this.lblProdid.Size = new System.Drawing.Size(56, 13);
            this.lblProdid.TabIndex = 0;
            this.lblProdid.Text = "Product Id";
            // 
            // dgvSearchProducts
            // 
            this.dgvSearchProducts.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvSearchProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProducts.Location = new System.Drawing.Point(12, 185);
            this.dgvSearchProducts.Name = "dgvSearchProducts";
            this.dgvSearchProducts.Size = new System.Drawing.Size(593, 229);
            this.dgvSearchProducts.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(488, 132);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvSearchProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmListProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search product";
            this.Load += new System.EventHandler(this.frmListProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label lblProdname;
        private System.Windows.Forms.Label lblProdid;
        private System.Windows.Forms.DataGridView dgvSearchProducts;
        private System.Windows.Forms.Button btnClose;
    }
}