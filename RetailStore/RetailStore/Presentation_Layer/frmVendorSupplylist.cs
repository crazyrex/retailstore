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
            d.loadTablesJoinIntoGrid("Vendor_Supplylist", "Entity", "Vendor_ID", "ID", dgvSearchVendors);
            dgvSearchVendors.Columns["ID"].Visible = false;
            dgvSearchVendors.Columns["Role"].Visible = false;
            dgvSearchVendors.Columns["Email"].Visible = false;
            txtVendorId.TextChanged +=new EventHandler(txtVendorId_TextChanged);
            txtProductId.TextChanged +=new EventHandler(txtVendorName_TextChanged);
            txtVendorName.Text = vendorName;
            DataTable dt = new DataTable();
            dt = d.findRecordsLike("Entity", "Name", vendorName);
            txtVendorId.Text=dt.Rows[0][0].ToString();
        }

        private void txtVendorId_TextChanged(object sender, EventArgs e)
        {
            d.loadTablesJoinIntoGrid("Entity", "Vendor_Supplylist", "ID", "Vendor_ID", "ID", txtVendorId.Text.Trim(), "Name", txtVendorName.Text.Trim(), "Product_ID", txtProductId.Text.Trim(), dgvSearchVendors);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVendorName_TextChanged(object sender, EventArgs e)
        {
            d.loadTablesJoinIntoGrid("Entity", "Vendor_Supplylist", "ID", "Vendor_ID", "ID", txtVendorId.Text.Trim(), "Name", txtVendorName.Text.Trim(), "Product_ID", txtProductId.Text.Trim(), dgvSearchVendors);
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            d.loadTablesJoinIntoGrid("Entity", "Vendor_Supplylist", "ID", "Vendor_ID", "ID", txtVendorId.Text.Trim(), "Name", txtVendorName.Text.Trim(), "Product_ID", txtProductId.Text.Trim(), dgvSearchVendors);
        }
        
    }
}
