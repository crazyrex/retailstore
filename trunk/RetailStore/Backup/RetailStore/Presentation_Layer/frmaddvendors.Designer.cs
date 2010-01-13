namespace RetailStore.Presentation_Layer
{
    partial class frmaddvendors
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
            this.lblvenname = new System.Windows.Forms.Label();
            this.lblvenid = new System.Windows.Forms.Label();
            this.txtvenid = new System.Windows.Forms.TextBox();
            this.txtvenname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnAddanother = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(144, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(228, 22);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "ADD VENDOR details here\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // lblvenname
            // 
            this.lblvenname.AutoSize = true;
            this.lblvenname.Location = new System.Drawing.Point(12, 73);
            this.lblvenname.Name = "lblvenname";
            this.lblvenname.Size = new System.Drawing.Size(61, 13);
            this.lblvenname.TabIndex = 2;
            this.lblvenname.Text = "Enter name";
            // 
            // lblvenid
            // 
            this.lblvenid.AutoSize = true;
            this.lblvenid.Location = new System.Drawing.Point(12, 44);
            this.lblvenid.Name = "lblvenid";
            this.lblvenid.Size = new System.Drawing.Size(52, 13);
            this.lblvenid.TabIndex = 3;
            this.lblvenid.Text = "Vendor id";
            // 
            // txtvenid
            // 
            this.txtvenid.Location = new System.Drawing.Point(96, 41);
            this.txtvenid.Name = "txtvenid";
            this.txtvenid.Size = new System.Drawing.Size(105, 20);
            this.txtvenid.TabIndex = 4;
            // 
            // txtvenname
            // 
            this.txtvenname.Location = new System.Drawing.Point(96, 67);
            this.txtvenname.Name = "txtvenname";
            this.txtvenname.Size = new System.Drawing.Size(160, 20);
            this.txtvenname.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(262, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other details";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(50, 314);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(147, 314);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnAddanother
            // 
            this.btnAddanother.Location = new System.Drawing.Point(399, 314);
            this.btnAddanother.Name = "btnAddanother";
            this.btnAddanother.Size = new System.Drawing.Size(107, 23);
            this.btnAddanother.TabIndex = 9;
            this.btnAddanother.Text = "Add more vendors";
            this.btnAddanother.UseVisualStyleBackColor = true;
            // 
            // frmaddvendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(539, 353);
            this.Controls.Add(this.btnAddanother);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtvenname);
            this.Controls.Add(this.txtvenid);
            this.Controls.Add(this.lblvenid);
            this.Controls.Add(this.lblvenname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmaddvendors";
            this.Text = "frmaddvendors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblvenname;
        private System.Windows.Forms.Label lblvenid;
        private System.Windows.Forms.TextBox txtvenid;
        private System.Windows.Forms.TextBox txtvenname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnAddanother;
    }
}