namespace RetailStore.Crystal_Reports
{
    partial class frmVendorReport
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
            this.crvVendorReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVendorReport
            // 
            this.crvVendorReport.ActiveViewIndex = -1;
            this.crvVendorReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVendorReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVendorReport.Location = new System.Drawing.Point(0, 0);
            this.crvVendorReport.Name = "crvVendorReport";
            this.crvVendorReport.SelectionFormula = "";
            this.crvVendorReport.Size = new System.Drawing.Size(906, 507);
            this.crvVendorReport.TabIndex = 0;
            this.crvVendorReport.ViewTimeSelectionFormula = "";
            // 
            // frmVendorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(906, 507);
            this.Controls.Add(this.crvVendorReport);
            this.Name = "frmVendorReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Report";
            this.Load += new System.EventHandler(this.frmVendorReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVendorReport;
    }
}