namespace RetailStore.Crystal_Reports
{
    partial class frmStockReport
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
            this.crwStockReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crwStockReport
            // 
            this.crwStockReport.ActiveViewIndex = -1;
            this.crwStockReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crwStockReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crwStockReport.Location = new System.Drawing.Point(0, 0);
            this.crwStockReport.Name = "crwStockReport";
            this.crwStockReport.SelectionFormula = "";
            this.crwStockReport.Size = new System.Drawing.Size(855, 529);
            this.crwStockReport.TabIndex = 0;
            this.crwStockReport.ViewTimeSelectionFormula = "";
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 529);
            this.Controls.Add(this.crwStockReport);
            this.Name = "frmStockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.frmStockReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crwStockReport;


    }
}