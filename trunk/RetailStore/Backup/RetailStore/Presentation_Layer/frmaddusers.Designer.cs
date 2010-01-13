namespace RetailStore.Presentation_Layer
{
    partial class frmaddusers
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
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblinfo.Location = new System.Drawing.Point(143, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(192, 23);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "ADD USER details here\r\n";
            // 
            // frmaddusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(533, 360);
            this.Controls.Add(this.lblinfo);
            this.Name = "frmaddusers";
            this.Text = "frmaddusers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblinfo;
    }
}