﻿namespace RetailStore.Presentation_Layer
{
    partial class frmListVendors
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.lblVendorname = new System.Windows.Forms.Label();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.lblVendorid = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.dgvSearchVendors = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVendorName);
            this.groupBox1.Controls.Add(this.lblVendorname);
            this.groupBox1.Controls.Add(this.txtVendorId);
            this.groupBox1.Controls.Add(this.lblVendorid);
            this.groupBox1.Location = new System.Drawing.Point(150, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(93, 68);
            this.txtVendorName.MaxLength = 255;
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(175, 20);
            this.txtVendorName.TabIndex = 2;
            this.txtVendorName.TextChanged += new System.EventHandler(this.txtVendorName_TextChanged);
            // 
            // lblVendorname
            // 
            this.lblVendorname.AutoSize = true;
            this.lblVendorname.Location = new System.Drawing.Point(16, 70);
            this.lblVendorname.Name = "lblVendorname";
            this.lblVendorname.Size = new System.Drawing.Size(72, 13);
            this.lblVendorname.TabIndex = 2;
            this.lblVendorname.Text = "Vendor Name";
            // 
            // txtVendorId
            // 
            this.txtVendorId.Location = new System.Drawing.Point(93, 30);
            this.txtVendorId.MaxLength = 6;
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(175, 20);
            this.txtVendorId.TabIndex = 1;
            this.txtVendorId.TextChanged += new System.EventHandler(this.txtVendorId_TextChanged);
            // 
            // lblVendorid
            // 
            this.lblVendorid.AutoSize = true;
            this.lblVendorid.Location = new System.Drawing.Point(16, 35);
            this.lblVendorid.Name = "lblVendorid";
            this.lblVendorid.Size = new System.Drawing.Size(53, 13);
            this.lblVendorid.TabIndex = 0;
            this.lblVendorid.Text = "Vendor Id";
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(240, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(133, 22);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "Search Vendors";
            // 
            // dgvSearchVendors
            // 
            this.dgvSearchVendors.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvSearchVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchVendors.Location = new System.Drawing.Point(21, 186);
            this.dgvSearchVendors.Name = "dgvSearchVendors";
            this.dgvSearchVendors.Size = new System.Drawing.Size(569, 222);
            this.dgvSearchVendors.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(617, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvSearchVendors);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListVendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search vendors";
            this.Load += new System.EventHandler(this.frmListVendors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchVendors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.Label lblVendorid;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label lblVendorname;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.DataGridView dgvSearchVendors;
        private System.Windows.Forms.Button btnClose;
    }
}