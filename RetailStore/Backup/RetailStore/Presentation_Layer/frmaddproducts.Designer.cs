namespace RetailStore.Presentation_Layer
{
    partial class frmaddproducts
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
            this.txtprodid = new System.Windows.Forms.TextBox();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.lblattri = new System.Windows.Forms.Label();
            this.txtprodattri = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblquan = new System.Windows.Forms.Label();
            this.txtprodqty = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(137, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(208, 23);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "ADD PRODUCT details here\r\n";
            // 
            // lblprodid
            // 
            this.lblprodid.Location = new System.Drawing.Point(12, 49);
            this.lblprodid.Name = "lblprodid";
            this.lblprodid.Size = new System.Drawing.Size(74, 19);
            this.lblprodid.TabIndex = 1;
            this.lblprodid.Text = "Product id";
            // 
            // lblprodname
            // 
            this.lblprodname.AutoSize = true;
            this.lblprodname.Location = new System.Drawing.Point(12, 80);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(61, 13);
            this.lblprodname.TabIndex = 2;
            this.lblprodname.Text = "Enter name";
            // 
            // txtprodid
            // 
            this.txtprodid.Location = new System.Drawing.Point(102, 46);
            this.txtprodid.Name = "txtprodid";
            this.txtprodid.Size = new System.Drawing.Size(100, 20);
            this.txtprodid.TabIndex = 3;
            // 
            // txtprodname
            // 
            this.txtprodname.Location = new System.Drawing.Point(102, 76);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.Size = new System.Drawing.Size(153, 20);
            this.txtprodname.TabIndex = 4;
            // 
            // lblattri
            // 
            this.lblattri.AutoSize = true;
            this.lblattri.Location = new System.Drawing.Point(14, 110);
            this.lblattri.Name = "lblattri";
            this.lblattri.Size = new System.Drawing.Size(51, 13);
            this.lblattri.TabIndex = 5;
            this.lblattri.Text = "Attributes";
            // 
            // txtprodattri
            // 
            this.txtprodattri.Location = new System.Drawing.Point(102, 105);
            this.txtprodattri.Name = "txtprodattri";
            this.txtprodattri.Size = new System.Drawing.Size(153, 20);
            this.txtprodattri.TabIndex = 6;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(15, 173);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(60, 13);
            this.lbldesc.TabIndex = 7;
            this.lbldesc.Text = "Description\r\n";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(102, 164);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(174, 57);
            this.txtdesc.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(287, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other details";
            // 
            // lblquan
            // 
            this.lblquan.AutoSize = true;
            this.lblquan.Location = new System.Drawing.Point(14, 141);
            this.lblquan.Name = "lblquan";
            this.lblquan.Size = new System.Drawing.Size(46, 13);
            this.lblquan.TabIndex = 10;
            this.lblquan.Text = "Quantity";
            // 
            // txtprodqty
            // 
            this.txtprodqty.Location = new System.Drawing.Point(102, 134);
            this.txtprodqty.Name = "txtprodqty";
            this.txtprodqty.Size = new System.Drawing.Size(153, 20);
            this.txtprodqty.TabIndex = 11;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(18, 239);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(115, 239);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // frmaddproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(537, 274);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtprodqty);
            this.Controls.Add(this.lblquan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.txtprodattri);
            this.Controls.Add(this.lblattri);
            this.Controls.Add(this.txtprodname);
            this.Controls.Add(this.txtprodid);
            this.Controls.Add(this.lblprodname);
            this.Controls.Add(this.lblprodid);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmaddproducts";
            this.Text = "frmaddproducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblprodid;
        private System.Windows.Forms.Label lblprodname;
        private System.Windows.Forms.TextBox txtprodid;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.Label lblattri;
        private System.Windows.Forms.TextBox txtprodattri;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblquan;
        private System.Windows.Forms.TextBox txtprodqty;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
    }
}