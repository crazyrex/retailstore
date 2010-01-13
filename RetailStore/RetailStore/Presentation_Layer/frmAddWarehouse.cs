using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmAddWarehouse : Form
    {
        private DAL d = new DAL();
        public frmAddWarehouse()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddWarehouse_Load(object sender, EventArgs e)
        {
            txtWarehouseId.Text = d.autoGenerateID("WH_Details", "WH_ID", "WH");
            d.loadTableIntoGrid("WH_Details", dgvWarehouse);
            txtWarehouseName.TextChanged    +=new EventHandler(txtWarehouseName_TextChanged);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //txtWarehouseId.Text = d.autoGenerateID("WH_Details", "WH_ID", "WH");
            d.addEntityAddress(txtWarehouseId.Text, txtAddress1.Text, txtAddress2.Text, txtAddress3.Text, txtCity.Text, txtPin.Text, txtState.Text, txtCountry.Text);
            d.addWarehouseDetails(txtWarehouseId.Text, txtWarehouseName.Text, txtContact.Text, txtCapacity.Text);
            clearTxt();
            MessageBox.Show("Warehouse added");
        }

        private void txtWarehouseName_TextChanged(object sender, EventArgs e)
        {
            dgvWarehouse.DataSource = d.findRecordsLike("WH_Details", "Name", txtWarehouseName.Text);
        }
        private void clearTxt()
        {
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
            txtCity.Text = "";
            txtPin.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
        }
    }
}
