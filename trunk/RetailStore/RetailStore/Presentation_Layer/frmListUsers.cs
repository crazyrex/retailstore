using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmListUsers : Form
    {
        DAL d = new DAL();
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            dgvSearchUsers.DataSource = d.findRecordsLike("Entity", "Role", "User", "ID", txtUserId.Text);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            dgvSearchUsers.DataSource = d.findRecordsLike("Entity", "Role", "User", "Name", txtUserName.Text);
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            d.loadTableIntoGrid("Entity", "Role", "User", dgvSearchUsers);
            txtUserId.TextChanged   += new EventHandler(txtUserId_TextChanged);
            txtUserName.TextChanged += new EventHandler(txtUserName_TextChanged);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
