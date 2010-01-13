namespace RetailStore.Crystal_Reports
{
    partial class frmPurchaseReport
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
            this.crvPurchaseReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPurchaseReport
            // 
            this.crvPurchaseReport.ActiveViewIndex = -1;
            this.crvPurchaseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPurchaseReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPurchaseReport.Location = new System.Drawing.Point(0, 0);
            this.crvPurchaseReport.Name = "crvPurchaseReport";
            this.crvPurchaseReport.SelectionFormula = "";
            this.crvPurchaseReport.Size = new System.Drawing.Size(912, 504);
            this.crvPurchaseReport.TabIndex = 0;
            this.crvPurchaseReport.ViewTimeSelectionFormula = "";
            // 
            // frmPurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(912, 504);
            this.Controls.Add(this.crvPurchaseReport);
            this.Name = "frmPurchaseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Report";
            this.Load += new System.EventHandler(this.frmPurchaseReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPurchaseReport;
    }
}