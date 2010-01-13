namespace RetailStore.Crystal_Reports
{
    partial class frmProductReport
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
            this.crvProductReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProductReport
            // 
            this.crvProductReport.ActiveViewIndex = -1;
            this.crvProductReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProductReport.Location = new System.Drawing.Point(0, 0);
            this.crvProductReport.Name = "crvProductReport";
            this.crvProductReport.SelectionFormula = "";
            this.crvProductReport.Size = new System.Drawing.Size(908, 517);
            this.crvProductReport.TabIndex = 0;
            this.crvProductReport.ViewTimeSelectionFormula = "";
            // 
            // frmProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.Controls.Add(this.crvProductReport);
            this.Name = "frmProductReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.frmProductReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductReport;
    }
}