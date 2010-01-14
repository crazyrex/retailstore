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
        REVAL r = new REVAL();
        Boolean b;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            validateInput();
            if (b)
            {
                MessageBox.Show("Please enter all fields with proper values");
            }
            else
            {
                d.addEntityInfo(txtVenId.Text, txtVenName.Text, txtPhone.Text, txtEmail.Text, "Vendor");
                d.addEntityAddress(txtVenId.Text, txtAddress1.Text, txtAddress2.Text, txtAddress3.Text, txtCity.Text, txtPin.Text, txtState.Text, txtCountry.Text);
                clearTxt();
                MessageBox.Show("Vendor added");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean validateInput()
        {
            b = false;
            if (r.emptyCheck(txtVenId.Text) && r.emptyCheck(txtVenName.Text) && r.emptyCheck(txtAddress1.Text) && r.emptyCheck(txtAddress2.Text) && r.emptyCheck(txtAddress3.Text) && r.emptyCheck(txtCity.Text) && r.emptyCheck(txtState.Text) && r.emptyCheck(txtPin.Text) && r.emptyCheck(txtCountry.Text) && r.emptyCheck(txtPhone.Text) && r.emptyCheck(txtEmail.Text))
            {
                b = true;
            }
            if (r.numCheck(txtPhone.Text) && r.numCheck(txtPin.Text))
            {
                b = true;
            }
            if (r.charCheck(txtVenName.Text) && r.charCheck(txtCity.Text) && r.charCheck(txtState.Text) && r.charCheck(txtCountry.Text))
            {
                b = true;
            }
            return b;
        }
    }
}