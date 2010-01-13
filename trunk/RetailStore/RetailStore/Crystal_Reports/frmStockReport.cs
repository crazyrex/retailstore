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
    public partial class frmStockReport : Form
    {
        DAL d = new DAL();
        private TableLogOnInfo log = new TableLogOnInfo();
        
        public frmStockReport()
        {
            InitializeComponent();
        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
           
            rptStock stock = new rptStock();
            stock.Database.Tables[0].ApplyLogOnInfo(log);
            try
            {
                datasetRetailStore ds = new datasetRetailStore();
                ds.Stock.Merge(d.dataStock()); //it will merge two tables
                stock.Database.Tables[0].SetDataSource(ds);
                crwStockReport.ReportSource = stock;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
  
        }
        

    }
}
