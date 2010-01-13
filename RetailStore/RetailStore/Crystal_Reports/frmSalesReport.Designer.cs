namespace RetailStore.Crystal_Reports
{
    partial class frmSalesReport
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
            this.crvSalesReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvSalesReport
            // 
            this.crvSalesReport.ActiveViewIndex = -1;
            this.crvSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesReport.Location = new System.Drawing.Point(0, 0);
            this.crvSalesReport.Name = "crvSalesReport";
            this.crvSalesReport.SelectionFormula = "";
            this.crvSalesReport.Size = new System.Drawing.Size(907, 511);
            this.crvSalesReport.TabIndex = 0;
            this.crvSalesReport.ViewTimeSelectionFormula = "";
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 511);
            this.Controls.Add(this.crvSalesReport);
            this.Name = "frmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesReport;
    }
}