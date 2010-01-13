namespace RetailStore.Crystal_Reports
{
    partial class frmCustomerReport
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
            this.crvCustomerReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCustomerReport
            // 
            this.crvCustomerReport.ActiveViewIndex = -1;
            this.crvCustomerReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCustomerReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCustomerReport.Location = new System.Drawing.Point(0, 0);
            this.crvCustomerReport.Name = "crvCustomerReport";
            this.crvCustomerReport.SelectionFormula = "";
            this.crvCustomerReport.Size = new System.Drawing.Size(902, 502);
            this.crvCustomerReport.TabIndex = 0;
            this.crvCustomerReport.ViewTimeSelectionFormula = "";
            // 
            // frmCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(902, 502);
            this.Controls.Add(this.crvCustomerReport);
            this.Name = "frmCustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.frmCustomerReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCustomerReport;
    }
}