namespace RetailStore.Presentation_Layer
{
    partial class frmaddcustomers
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
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnaddanother = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(130, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(242, 23);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "ADD CUSTOMER details here";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Location = new System.Drawing.Point(12, 47);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(62, 13);
            this.lblcustid.TabIndex = 1;
            this.lblcustid.Text = "Customer id";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Location = new System.Drawing.Point(12, 73);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(61, 13);
            this.lblcustname.TabIndex = 2;
            this.lblcustname.Text = "Enter name";
            // 
            // txtcustid
            // 
            this.txtcustid.Location = new System.Drawing.Point(94, 44);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(100, 20);
            this.txtcustid.TabIndex = 3;
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(94, 70);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(156, 20);
            this.txtcustname.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(258, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 182);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other details";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(43, 305);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(133, 305);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnaddanother
            // 
            this.btnaddanother.Location = new System.Drawing.Point(363, 305);
            this.btnaddanother.Name = "btnaddanother";
            this.btnaddanother.Size = new System.Drawing.Size(120, 23);
            this.btnaddanother.TabIndex = 9;
            this.btnaddanother.Text = "Add more customers";
            this.btnaddanother.UseVisualStyleBackColor = true;
            // 
            // frmaddcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(499, 344);
            this.Controls.Add(this.btnaddanother);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.txtcustid);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmaddcustomers";
            this.Text = "frmaddcustomers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnaddanother;
    }
}