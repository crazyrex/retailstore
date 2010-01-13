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
    public partial class frmSalesReport : Form
    {
        DAL d = new DAL();
        private TableLogOnInfo log = new TableLogOnInfo();
        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            rptSales rs = new rptSales();
            rs.Database.Tables[0].ApplyLogOnInfo(log);
            try
            {
                datasetRetailStore ds = new datasetRetailStore();
                ds.Sales.Merge(d.dataSales());
                rs.Database.Tables[0].SetDataSource(ds);
                crvSalesReport.ReportSource = rs;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
