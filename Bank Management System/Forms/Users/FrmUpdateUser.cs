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
    public partial class FrmUpdateUser : Form
    {

        enum enMode { Search, Update}
        enMode _Mode;
        
       
        User _User1;
        public FrmUpdateUser()
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
            txtPassword.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtPermissions.Clear();

            txtUsername.Enabled = true;
            btnClear.Visible = false;
            btnPermission.Enabled = false;
            _Mode = enMode.Search;
            btnSearchAndUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnSearchAndUpdate.Text = "Search";
            txtUsername.Focus();

            _EnabledJusttxtUsername();
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
            _User1.Email = txtEmail.Text;


            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required!");
                return false;
            }
            _User1.PhoneNumber = txtPhone.Text;


            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length <=3)
            {
                MessageBox.Show("Invalid Balance Value!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _User1.Password = txtPassword.Text;



            _User1.Permission = Convert.ToInt32(txtPermissions.Text);

            return true;


        }


        private void btnSearchAndUpdate_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                if(!_FillData())
                {
                    return;
                }

                if(txtUsername.Text== "Admin")
                {
                    MessageBox.Show("You cannot Update the Admin.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Update this User ", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                    if (_User1.Save())
                {
                    MessageBox.Show($"User Updated Successfully [{txtUsername.Text}] ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   btnClear.PerformClick();
                    return;
                }
                else
                {
                    MessageBox.Show($"Failed to Update User [{txtUsername.Text}] ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            if (_Mode == enMode.Search)
            {

                if(!User.IsUserExists(txtUsername.Text))
                {
                    MessageBox.Show($"User [{txtUsername.Text}] Not Exists ", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _User1 = User.FindUserByUsername(txtUsername.Text);

                txtUsername.Text = _User1.Username;
                txtFirstName.Text = _User1.FirstName;
                txtLastName.Text = _User1.LastName;
                txtEmail.Text = _User1.Email;
                txtPhone.Text = _User1.PhoneNumber;
                txtPassword.Text = _User1.Password;
                txtPermissions.Text = _User1.Permission.ToString() ; 
                

                btnSearchAndUpdate.Text = "Update";
                btnSearchAndUpdate.BackColor = Color.FromArgb(40, 167, 69);
                btnPermission.Enabled = true ;
                btnClear.Visible = true;
                txtUsername.Enabled = false;
                _Mode = enMode.Update;
                _EnabledAlltxtBoxies();
            }
        }

        private void _EnabledAlltxtBoxies()
        {

            txtPassword.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
           
        }

        private void _EnabledJusttxtUsername()
        {

            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
            txtPermissions.Enabled = false;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            FrmPermissions frm = new FrmPermissions(_User1.Permission);

            frm.ShowDialog();

            txtPermissions.Text = FrmPermissions.Permission.ToString();
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
