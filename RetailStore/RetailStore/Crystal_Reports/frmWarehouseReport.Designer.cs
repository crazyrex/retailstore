namespace RetailStore.Crystal_Reports
{
    partial class frmWarehouseReport
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
            this.crvWarehouseReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvWarehouseReport
            // 
            this.crvWarehouseReport.ActiveViewIndex = -1;
            this.crvWarehouseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvWarehouseReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvWarehouseReport.Location = new System.Drawing.Point(0, 0);
            this.crvWarehouseReport.Name = "crvWarehouseReport";
            this.crvWarehouseReport.SelectionFormula = "";
            this.crvWarehouseReport.Size = new System.Drawing.Size(901, 506);
            this.crvWarehouseReport.TabIndex = 0;
            this.crvWarehouseReport.ViewTimeSelectionFormula = "";
            // 
            // frmWarehouseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(901, 506);
            this.Controls.Add(this.crvWarehouseReport);
            this.Name = "frmWarehouseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Report";
            this.Load += new System.EventHandler(this.frmWarehouseReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvWarehouseReport;
    }
}