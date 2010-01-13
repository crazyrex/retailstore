using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RetailStore.Crystal_Reports
{
    public partial class frmPurchaseReport : Form
    {
        DAL d = new DAL();
        private TableLogOnInfo log = new TableLogOnInfo();
        public frmPurchaseReport()
        {
            InitializeComponent();
        }

        private void frmPurchaseReport_Load(object sender, EventArgs e)
        {
            rptPurchase rp = new rptPurchase();
            rp.Database.Tables[0].ApplyLogOnInfo(log);
            //rp.Load("D:\\StudyRoom\\MyRoom\\RetailStore\\RetailStore\\RetailStore\\Crystal_Reports\\rptPurchase.rpt");
            try
            {
                datasetRetailStore ds = new datasetRetailStore();
                ds.Purchase.Merge(d.dataPurchase());
                rp.Database.Tables[0].SetDataSource(ds);
                crvPurchaseReport.ReportSource=rp;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
