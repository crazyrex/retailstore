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
    public partial class frmCustomerReport : Form
    {
        DAL d = new DAL();
        private TableLogOnInfo log = new TableLogOnInfo();
        public frmCustomerReport()
        {
            InitializeComponent();
        }

        private void frmCustomerReport_Load(object sender, EventArgs e)
        {
            rptCustomer rc = new rptCustomer();
            rc.Database.Tables[0].ApplyLogOnInfo(log);
            try
            {
                datasetRetailStore ds = new datasetRetailStore();
                ds.Customer.Merge(d.dataVendorsCustomers("Customer"));
                rc.Database.Tables[0].SetDataSource(ds);
                crvCustomerReport.ReportSource = rc;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show( ex.Message.ToString());
            }
        }
    }
}
