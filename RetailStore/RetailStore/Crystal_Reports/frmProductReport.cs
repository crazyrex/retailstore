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
    public partial class frmProductReport : Form
    {
        DAL d = new DAL();
        private TableLogOnInfo log = new TableLogOnInfo();
        public frmProductReport()
        {
            InitializeComponent();
        }

        private void frmProductReport_Load(object sender, EventArgs e)
        {
            rptProduct rprod = new rptProduct();
            rprod.Database.Tables[0].ApplyLogOnInfo(log);
            try
            {
                datasetRetailStore ds = new datasetRetailStore();
                ds.Product.Merge(d.dataProduct());
                rprod.Database.Tables[0].SetDataSource(ds);
                crvProductReport.ReportSource = rprod;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
