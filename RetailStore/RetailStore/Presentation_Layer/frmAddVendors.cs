using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmAddVendors : Form
    {
        private DAL d = new DAL();
        public frmAddVendors()
        {
            InitializeComponent();
        }

        private void frmaddvendors_Load(object sender, EventArgs e)
        {
            d.loadTableIntoGrid("Entity", "Role", "Vendor", dgvVendors);

            txtVenName.TextChanged += new EventHandler(txtVenName_TextChanged);

            txtVenId.Text = d.autoGenerateID("Entity", "ID", "Vendor");


            txtVenId.TextChanged += new EventHandler(txtVenId_TextChanged);
            

        }

        void txtVenId_TextChanged(object sender, EventArgs e)
        {
            dgvVendors.DataSource = d.findRecordsLike("Entity", "Role", "Vendor", "ID", txtVenId.Text);
        }

        private void clearTxt() {
            txtVenId.Text = "";
            txtVenName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
            txtCity.Text = "";
            txtPin.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
        }

        private void txtVenName_TextChanged(object sender, EventArgs e)
        {
            dgvVendors.DataSource = d.findRecordsLike("Entity", "Role", "Vendor", "Name", txtVenName.Text);
        }

        private void btnadd_Click(object sender, EventArgs e){
            d.addEntityInfo(txtVenId.Text, txtVenName.Text, txtPhone.Text, txtEmail.Text, "Vendor");
            d.addEntityAddress(txtVenId.Text, txtAddress1.Text, txtAddress2.Text, txtAddress3.Text, txtCity.Text, txtPin.Text, txtState.Text, txtCountry.Text);
            clearTxt();
            MessageBox.Show("Vendor added");
            //txtVenId.Text = d.autoGenerateID("Entity", "ID", "Vendor");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}