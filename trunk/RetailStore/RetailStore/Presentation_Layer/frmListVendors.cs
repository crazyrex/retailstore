using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmListVendors : Form
    {
        DAL d = new DAL();
        public frmListVendors()
        {
            InitializeComponent();
        }

        private void txtVendorId_TextChanged(object sender, EventArgs e)
        {
            dgvSearchVendors.DataSource= d.findRecordsLike("Entity", "Role", "Vendor", "ID", txtVendorId.Text);
        }

        private void txtVendorName_TextChanged(object sender, EventArgs e)
        {
            dgvSearchVendors.DataSource = d.findRecordsLike("Entity", "Role", "Vendor", "Name", txtVendorName.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListVendors_Load(object sender, EventArgs e)
        {
            d.loadTableIntoGrid("Entity", "Role", "Vendor", dgvSearchVendors);

            txtVendorId.TextChanged += new EventHandler(txtVendorId_TextChanged);
            txtVendorName.TextChanged += new EventHandler(txtVendorName_TextChanged);
        }
    }
}
