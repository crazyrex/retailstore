using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmListWarehouses : Form
    {
        DAL d = new DAL();
        public frmListWarehouses()
        {
            InitializeComponent();
        }

        private void txtWhId_TextChanged(object sender, EventArgs e)
        {
            dgvSearchWarehouses.DataSource = d.findRecordsLike("WH_Details", "WH_ID", txtWhId.Text);
        }

        private void txtWhName_TextChanged(object sender, EventArgs e)
        {
            dgvSearchWarehouses.DataSource = d.findRecordsLike("WH_Details", "Name", txtWhName.Text);
        }

        private void frmListWarehouses_Load(object sender, EventArgs e)
        {
            d.loadTableIntoGrid("WH_Details",dgvSearchWarehouses);

            txtWhId.TextChanged += new EventHandler(txtWhId_TextChanged);
            txtWhName.TextChanged += new EventHandler(txtWhName_TextChanged);
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
