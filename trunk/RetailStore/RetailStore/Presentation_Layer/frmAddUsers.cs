using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmAddUsers : Form
    {
        private DAL d=new DAL();
        public frmAddUsers()
        {
            InitializeComponent();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddUsers_Load(object sender, EventArgs e)
        {
            txtUserId.Text = d.autoGenerateID("Entity", "ID", "Employee");
            d.loadTableIntoGrid("Entity", "Role", "User", dgvUsers);
            txtUserId.TextChanged += new EventHandler(txtUserId_TextChanged);
            txtUserName.TextChanged += new EventHandler(txtUserName_TextChanged);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //txtUserId.Text = d.autoGenerateID("Entity", "ID", "Employee");
            d.addEntityInfo(txtUserId.Text, txtUserName.Text, txtPhone.Text, txtEmail.Text, "User");
            d.addEntityAddress(txtUserId.Text, txtAddress1.Text, txtAddress2.Text, txtAddress3.Text, txtCity.Text, txtPin.Text, txtState.Text, txtCountry.Text);
            clearTxt();
            MessageBox.Show("User added");
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource= d.findRecordsLike("Entity", "Role","User","Name", txtUserName.Text);
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource = d.findRecordsLike("Entity", "Role", "User", "ID", txtUserId.Text);
        }
        private void clearTxt()
        {
            txtUserId.Text = "";
            txtUserName.Text = "";
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
        
    }
}