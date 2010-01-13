using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmVendorSupplylist : Form
    {
        private DAL d=new DAL();
        string vendorName;
        public frmVendorSupplylist()
        {
            InitializeComponent();
        }
        public frmVendorSupplylist(string vendorID)
        {
            vendorName = vendorID;
            InitializeComponent();
        }
        private void frmVendorSupplylist_Load(object sender, EventArgs e)
        {
            d.loadTableIntoGrid("vendor_Supplylist", dgvSearchVendors);
            txtVendorId.TextChanged +=new EventHandler(txtVendorId_TextChanged);
            txtVendorName.TextChanged +=new EventHandler(txtVendorName_TextChanged);
            txtVendorName.Text = vendorName;
        }

        private void txtVendorId_TextChanged(object sender, EventArgs e)
        {
            dgvSearchVendors.DataSource = d.findRecordsLike("Vendor_Supplylist", "Vendor_ID", txtVendorId.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVendorName_TextChanged(object sender, EventArgs e)
        {
            dgvSearchVendors.DataSource = d.findRecordsLike("Vendor_Supplylist", "Product_ID", txtVendorName.Text);
        }
    }
}
