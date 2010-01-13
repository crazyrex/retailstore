using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetailStore.Crystal_Reports;

namespace RetailStore.Presentation_Layer
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVendors av = new frmAddVendors();
            av.MdiParent = this;
            av.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProducts ap = new frmAddProducts();
            ap.MdiParent = this;
            ap.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomers ac = new frmAddCustomers();
            ac.MdiParent = this;
            ac.Show();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUsers au = new frmAddUsers();
            au.MdiParent = this;
            au.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmaboutus us = new frmaboutus();
            us.MdiParent = this;
            us.Show();
        }

        private void newPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPur_Order np = new frmNewPur_Order();
            np.MdiParent = this;
            np.Show();
        }

        private void newSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnewsales_order ns = new frmnewsales_order();
            ns.MdiParent = this;
            ns.Show();
        }

        private void salaryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalary s = new frmSalary();
            s.MdiParent = this;
            s.Show();
        }

        private void timesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimesheet t = new frmTimesheet();
            t.MdiParent = this;
            t.Show();
        }

        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddWarehouse aw = new frmAddWarehouse();
            aw.MdiParent = this;
            aw.Show();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListProducts lp = new frmListProducts();
            lp.MdiParent = this;
            lp.Show();
        }

        private void vendorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListVendors lv = new frmListVendors();
            lv.MdiParent = this;
            lv.Show();
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListCustomers lc = new frmListCustomers();
            lc.MdiParent = this;
            lc.Show();
        }

        private void usersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListUsers lu = new frmListUsers();
            lu.MdiParent = this;
            lu.Show();
        }

        private void warehousesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListWarehouses lw = new frmListWarehouses();
            lw.MdiParent = this;
            lw.Show();
        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockReport sr = new frmStockReport();
            sr.MdiParent = this;
            sr.Show();
        }

        private void vendorOrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseReport pr = new frmPurchaseReport();
            pr.MdiParent = this;
            pr.Show();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductReport fp = new frmProductReport();
            fp.MdiParent = this;
            fp.Show();
        }

        private void purToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendorReport frv = new frmVendorReport();
            frv.MdiParent = this;
            frv.Show();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerReport fcr = new frmCustomerReport();
            fcr.MdiParent = this;
            fcr.Show();
        }

        private void warehouseDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmWarehouseReport fwr = new frmWarehouseReport();
            fwr.MdiParent = this;
            fwr.Show();

        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReport fsr = new frmSalesReport();
            fsr.MdiParent = this;
            fsr.Show();
        }

        private void vendorSupplylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendorSupplylist vs = new frmVendorSupplylist();
            vs.MdiParent = this;
            vs.Show();
        }

    }
}