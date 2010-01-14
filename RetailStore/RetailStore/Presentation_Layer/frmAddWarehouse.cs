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
        REVAL r = new REVAL();
        Boolean b;
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
            validateInput();
            if (b)
            {
                MessageBox.Show("Please enter all fields with proper values");
            }
            else
            {
                d.addEntityAddress(txtWarehouseId.Text, txtAddress1.Text, txtAddress2.Text, txtAddress3.Text, txtCity.Text, txtPin.Text, txtState.Text, txtCountry.Text);
                d.addWarehouseDetails(txtWarehouseId.Text, txtWarehouseName.Text, txtContact.Text, txtCapacity.Text);
                clearTxt();
                MessageBox.Show("Warehouse added");
            }
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
        public Boolean validateInput()
        {
            b = false;
            if (r.emptyCheck(txtWarehouseId.Text) && r.emptyCheck(txtWarehouseName.Text) && r.emptyCheck(txtAddress1.Text) && r.emptyCheck(txtAddress2.Text) && r.emptyCheck(txtAddress3.Text) && r.emptyCheck(txtCity.Text) && r.emptyCheck(txtState.Text) && r.emptyCheck(txtPin.Text) && r.emptyCheck(txtCountry.Text) && r.emptyCheck(txtContact.Text) && r.emptyCheck(txtCapacity.Text))
            {
                b = true;
            }
            if (r.numCheck(txtContact.Text) && r.numCheck(txtPin.Text) && r.emptyCheck(txtCapacity.Text))
            {
                b = true;
            }
            if (r.charCheck(txtWarehouseName.Text) && r.charCheck(txtCity.Text) && r.charCheck(txtState.Text) && r.charCheck(txtCountry.Text))
            {
                b = true;
            }
            return b;
        }
    }
}
