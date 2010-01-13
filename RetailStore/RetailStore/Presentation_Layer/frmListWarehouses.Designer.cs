namespace RetailStore.Presentation_Layer
{
    partial class frmListWarehouses
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
            this.txtWhName = new System.Windows.Forms.TextBox();
            this.lblwhname = new System.Windows.Forms.Label();
            this.txtWhId = new System.Windows.Forms.TextBox();
            this.lblwhid = new System.Windows.Forms.Label();
            this.dgvSearchWarehouses = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchWarehouses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(221, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(177, 22);
            this.lblinfo.TabIndex = 3;
            this.lblinfo.Text = "Search Warehouses";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWhName);
            this.groupBox1.Controls.Add(this.lblwhname);
            this.groupBox1.Controls.Add(this.txtWhId);
            this.groupBox1.Controls.Add(this.lblwhid);
            this.groupBox1.Location = new System.Drawing.Point(128, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // txtWhName
            // 
            this.txtWhName.Location = new System.Drawing.Point(120, 67);
            this.txtWhName.MaxLength = 255;
            this.txtWhName.Name = "txtWhName";
            this.txtWhName.Size = new System.Drawing.Size(175, 20);
            this.txtWhName.TabIndex = 2;
            this.txtWhName.TextChanged += new System.EventHandler(this.txtWhName_TextChanged);
            // 
            // lblwhname
            // 
            this.lblwhname.AutoSize = true;
            this.lblwhname.Location = new System.Drawing.Point(16, 70);
            this.lblwhname.Name = "lblwhname";
            this.lblwhname.Size = new System.Drawing.Size(93, 13);
            this.lblwhname.TabIndex = 2;
            this.lblwhname.Text = "Warehouse Name";
            // 
            // txtWhId
            // 
            this.txtWhId.Location = new System.Drawing.Point(120, 28);
            this.txtWhId.MaxLength = 6;
            this.txtWhId.Name = "txtWhId";
            this.txtWhId.Size = new System.Drawing.Size(175, 20);
            this.txtWhId.TabIndex = 1;
            this.txtWhId.TextChanged += new System.EventHandler(this.txtWhId_TextChanged);
            // 
            // lblwhid
            // 
            this.lblwhid.AutoSize = true;
            this.lblwhid.Location = new System.Drawing.Point(16, 35);
            this.lblwhid.Name = "lblwhid";
            this.lblwhid.Size = new System.Drawing.Size(74, 13);
            this.lblwhid.TabIndex = 0;
            this.lblwhid.Text = "Warehouse Id";
            // 
            // dgvSearchWarehouses
            // 
            this.dgvSearchWarehouses.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvSearchWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchWarehouses.Location = new System.Drawing.Point(22, 191);
            this.dgvSearchWarehouses.Name = "dgvSearchWarehouses";
            this.dgvSearchWarehouses.Size = new System.Drawing.Size(569, 222);
            this.dgvSearchWarehouses.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(471, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmListWarehouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvSearchWarehouses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmListWarehouses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List warehouses";
            this.Load += new System.EventHandler(this.frmListWarehouses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchWarehouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWhName;
        private System.Windows.Forms.Label lblwhname;
        private System.Windows.Forms.TextBox txtWhId;
        private System.Windows.Forms.Label lblwhid;
        private System.Windows.Forms.DataGridView dgvSearchWarehouses;
        private System.Windows.Forms.Button btnClose;
    }
}