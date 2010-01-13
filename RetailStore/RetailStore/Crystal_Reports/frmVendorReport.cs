using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace RetailStore.Crystal_Reports
{
    public partial class frmVendorReport : Form
    {
        DAL d = new DAL();
        private TableLogOnInfo log = new TableLogOnInfo();
        public frmVendorReport()
        {
            InitializeComponent();
        }

        private void frmVendorReport_Load(object sender, EventArgs e)
        {
            rptVendor rv = new rptVendor();
            rv.Database.Tables[0].ApplyLogOnInfo(log);
            try
            {
                datasetRetailStore ds = new datasetRetailStore();
                ds.Vendor.Merge(d.dataVendorsCustomers("Vendor"));
                rv.Database.Tables[0].SetDataSource(ds);
                crvVendorReport.ReportSource = rv;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
