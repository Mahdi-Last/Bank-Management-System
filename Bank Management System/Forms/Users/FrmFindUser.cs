using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Users
{
    public partial class FrmFindUser : Form
    {
        enum enMode { Search, Clear}
        enMode _Mode;
        User _User;
        public FrmFindUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmUsers());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

                txtUsername.Clear();
                txtPermissions.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();

            btnSearch.Enabled = true;
            btnClear.Visible = false;
            _Mode = enMode.Search;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Search)
            {

                if(!User.IsUserExists(txtUsername.Text))
                {
                    MessageBox.Show($"User Not Found [{txtUsername.Text}] Try Another One", "Find", MessageBoxButtons.OK);
                    return;
                }

                _User = User.FindUserByUsername(txtUsername.Text);


                txtUsername.Text = _User.Username;
                txtFirstName.Text = _User.FirstName;
                txtLastName.Text = _User.LastName;
                txtEmail.Text = _User.Email;
                txtPhone.Text = _User.PhoneNumber;
                txtPassword.Text = _User.Password;
                txtPermissions.Text = _User.Permission.ToString();

                btnSearch.Enabled = false;
                btnClear.Visible = true;
                _Mode = enMode.Clear;

            }
        }

        private void txtPermissions_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPermission_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblAccountNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFindUser_Load(object sender, EventArgs e)
        {

        }
    }
}
