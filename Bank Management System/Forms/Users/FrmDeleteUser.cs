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
    public partial class FrmDeleteUser : Form
    {

        enum enMode { Search, Delete}
        enMode _Mode;
        User _User;
        
        public FrmDeleteUser()
        {
            InitializeComponent();
        }

        public void _DeleteUser()
        {
            if(User.DeleteUser(txtUsername.Text))
            {
                MessageBox.Show("User Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Failed to delete User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchAndDelete_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Delete)
            {
                if(txtUsername.Text == "Admin")
                {
                    MessageBox.Show("You cannot delete the Admin.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Delete this User ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                    _DeleteUser();
                    btnClear.PerformClick();
                    return;

                }
                return;

            }

            if (!User.IsUserExists(txtUsername.Text))
            {
                MessageBox.Show("User does not exist!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            _Mode = enMode.Delete;
            btnSearchAndDelete.Text = "Delete";
            btnSearchAndDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnClear.Visible = true;
            txtUsername.Enabled = false;

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

            txtUsername.Enabled = true;
            btnClear.Visible = false;
            _Mode = enMode.Search;
            btnSearchAndDelete.Text = "Search";
            btnSearchAndDelete.BackColor = Color.FromArgb(0, 123, 255);
            txtUsername.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmUsers());
        }

        private void FrmDeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}
