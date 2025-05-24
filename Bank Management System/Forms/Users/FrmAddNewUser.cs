using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Users
{
    public partial class FrmAddNewUser : Form
    {

        User _User1 = new User();

      
        public FrmAddNewUser()
        {
            InitializeComponent();
        }

        private bool _FillData()
        {
            if (txtUsername.Text.Length <= 3 || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show($"Username [{txtUsername.Text}] Not Valid. Try another one!");
                return false;
            }

            _User1.Username = txtUsername.Text;


            if (txtFirstName.Text.Length < 3 || string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show($"First Name [{txtFirstName.Text}] Is Too Short. Try Another One!");
                return false;
            }

            _User1.FirstName = txtFirstName.Text;

            if (txtLastName.Text.Length < 3 || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show($"Last Name [{txtLastName.Text}] Is Too Short. Try Another One!");
                return false;
            }
            _User1.LastName = txtLastName.Text;

                    if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email is required!");
                    return false;
                }
                else if (txtEmail.Text.Length < 8)
                {
                    MessageBox.Show("Email is less than 8!");
                    return false;
                }
                _User1.Email = txtEmail.Text;
                
                
                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Phone number is required!");
                    return false;
                }
                else if (txtPhone.Text.Length < 8)
                {
                    MessageBox.Show("Phone Number is less than 8!");
                    return false;
                }
                _User1.PhoneNumber = txtPhone.Text;

            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length <= 3)
            {
                MessageBox.Show("Invalid Balance Value!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _User1.Password = txtPassword.Text;



            _User1.Permission = FrmPermissions.Permission;

            return true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmUsers());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            EnableAlltxtBoxies();

            btnClear.Visible = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!User.IsUserExists(txtUsername.Text))
            {
                if (!_FillData())
                {
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Add this User ", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                    if (_User1.Save())
                {
                    MessageBox.Show($"User Added Seccessfully [{txtUsername.Text}] ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableAlltxtBoxies();
                    btnClear.Visible = true;
                    return;
                }
                else
                {
                    MessageBox.Show($"Failed to add User [{txtUsername.Text}] ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show($"This Username All Ready Exist [{txtUsername.Text}] ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DisableAlltxtBoxies()
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
           
        }

        public void EnableAlltxtBoxies()
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
        }
        private void btnPermission_Click(object sender, EventArgs e)
        {
            FrmPermissions frm = new FrmPermissions(0);

            frm.ShowDialog();

          

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

        private void lblEmail_Click(object sender, EventArgs e)
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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
