using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmListCustomers : Form
    {
        DAL d = new DAL();
        public frmListCustomers()
        {
            InitializeComponent();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            dgvSearchCustomers.DataSource = d.findRecordsLike("Entity", "Role", "Customer", "ID", txtCustomerId.Text);
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            d.loadTableIntoGrid("Entity", "Role", "Customer", dgvSearchCustomers);
           
            txtCustomerId.TextChanged += new EventHandler(txtCustomerId_TextChanged);
            txtCustomerName.TextChanged += new EventHandler(txtCustomerName_TextChanged);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            dgvSearchCustomers.DataSource = d.findRecordsLike("Entity", "Role", "Customer", "Name",txtCustomerName.Text);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
