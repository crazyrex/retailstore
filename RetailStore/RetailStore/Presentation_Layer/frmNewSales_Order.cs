using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetailStore.Presentation_Layer;

namespace RetailStore
{
    public partial class frmnewsales_order : Form
    {
        private DAL d = new DAL();

        public frmnewsales_order()
        {
            InitializeComponent();
        }

        //private void btnnewcust_Click(object sender, EventArgs e)
        //{
        //    frmAddCustomers ac = new frmAddCustomers();
        //    //ac.MdiParent = this;
        //    ac.Show();
        //    this.Close();
        //}

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmnewsales_order_Load(object sender, EventArgs e)
        {
            txtSalesId.Text = d.autoGenerateID( "SOrders_Details", "SO_ID","SO");

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            txtSalesId.Text = d.autoGenerateID( "SOrders_Details", "SO_ID","SO");
        }

        private void lblinfo_Click(object sender, EventArgs e)
        {

        }
    }
}
