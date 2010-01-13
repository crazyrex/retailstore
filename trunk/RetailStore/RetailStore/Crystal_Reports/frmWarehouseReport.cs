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
    public partial class frmWarehouseReport : Form
    {
        DAL d = new DAL();
        private TableLogOnInfo log = new TableLogOnInfo();
        public frmWarehouseReport()
        {
            InitializeComponent();
        }

        private void frmWarehouseReport_Load(object sender, EventArgs e)
        {
            rptWarehouse rw = new rptWarehouse();
            rw.Database.Tables[0].ApplyLogOnInfo(log);
            try
            {
                datasetRetailStore ds = new datasetRetailStore();
                ds.Warehouse.Merge(d.dataWarehouse());
                rw.Database.Tables[0].SetDataSource(ds);
                crvWarehouseReport.ReportSource = rw;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
