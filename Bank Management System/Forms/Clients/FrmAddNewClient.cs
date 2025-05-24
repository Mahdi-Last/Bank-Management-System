using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bank_Management_System.Clients;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Clients
{
    public partial class FrmAddNewClient : Form
    {

        Client _Client1 = new Client();
        public FrmAddNewClient()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmClients());
        }
        private bool _FillData()
        {
            if (txtAccountNumber.Text.Length <= 3 || string.IsNullOrEmpty(txtAccountNumber.Text) )
            {
                MessageBox.Show($"Account Number [{txtAccountNumber.Text}] Not Valid. Try another one!");
                return false;
            }

            _Client1.AccountNumber = txtAccountNumber.Text;


            if(txtFirstName.Text.Length < 3 || string.IsNullOrEmpty( txtFirstName.Text))
            {
                MessageBox.Show($"First Name [{txtFirstName.Text}] Is Too Short. Try Another One!");
                return false;
            }

            _Client1.FirstName = txtFirstName.Text;

            if(txtLastName.Text.Length < 3  || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show($"Last Name [{txtLastName.Text}] Is Too Short. Try Another One!");
                return false;
            }
            _Client1.LastName = txtLastName.Text;

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
            _Client1.Email = txtEmail.Text;
            
            
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
            _Client1.PhoneNumber = txtPhone.Text;



            if (!decimal.TryParse(txtBalance.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal balance))
            {
                MessageBox.Show("Invalid Balance Value!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _Client1.Balance = balance;

            if(string.IsNullOrEmpty(txtPinCode.Text) || txtPinCode.Text.Length != 4)
            {
                MessageBox.Show("Invalid PinCode!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _Client1.PinCode = txtPinCode.Text;

            return true;


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Client.IsClientExist(txtAccountNumber.Text))
            {
                 if(!_FillData())
                {
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Add this Client ", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                if (_Client1.Save())
                    {
                        MessageBox.Show($"Client Added Seccessfully [{txtAccountNumber.Text}] ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       DisableAlltxtBoxies();
                    
                    }
                    else
                    {
                        MessageBox.Show($"Failed to add client [{txtAccountNumber.Text}] ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            else
                MessageBox.Show($"This Account Number All Ready Exist [{txtAccountNumber.Text}] ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisableAlltxtBoxies()
        {
            txtAccountNumber.Enabled = false;
            txtPinCode.Enabled = false;
            txtBalance.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
        }

        private void EnableAlltxtBoxies()
        {
            txtAccountNumber.Enabled = true;
            txtPinCode.Enabled = true;
            txtBalance.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Clear();
            txtPinCode.Clear();
            txtBalance.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            EnableAlltxtBoxies();
        }

        private void FrmAddNewClient_Load(object sender, EventArgs e)
        {

        }
    }
}
