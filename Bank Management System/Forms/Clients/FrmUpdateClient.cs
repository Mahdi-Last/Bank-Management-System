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
using Bank_Management_System.Clients;
using BankBusinessLayer;
using static BankBusinessLayer.Client;

namespace Bank_Management_System.Forms.Clients
{
    public partial class FrmUpdateClient : Form
    {

        enum enMode { Search, Update };
        enMode _Mode;
        Client _Client1;
        public FrmUpdateClient()
        {
            InitializeComponent();
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

            btnSearchAndUpdate.Text = "Search";
            btnClear.Visible = false;
            _Mode = enMode.Search;
            txtAccountNumber.Focus();

            _EnabledJustAccountNumber();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmClients());
        }

        private void _EnabledJustAccountNumber()
        {
            txtAccountNumber.Enabled = true;
            txtPinCode.Enabled = false;
            txtBalance.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;

        }

        private void _DisabledJustAccountNumber()
        {
            txtAccountNumber.Enabled = false;
            txtPinCode.Enabled = true;
            txtBalance.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
        }

        private bool _FillData()
        {
            if (txtAccountNumber.Text.Length <= 3 || string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                MessageBox.Show($"Account Number [{txtAccountNumber.Text}] Not Valid. Try another one!");
                return false;
            }

            _Client1.AccountNumber = txtAccountNumber.Text;


            if (txtFirstName.Text.Length < 3 || string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show($"First Name [{txtFirstName.Text}] Is Too Short. Try Another One!");
                return false;
            }

            _Client1.FirstName = txtFirstName.Text;

            if (txtLastName.Text.Length < 3 || string.IsNullOrEmpty(txtLastName.Text))
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

            if (string.IsNullOrEmpty(txtPinCode.Text) || txtPinCode.Text.Length != 4)
            {
                MessageBox.Show("Invalid PinCode!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _Client1.PinCode = txtPinCode.Text;

            return true;


        }
 
        private void btnSearchAndUpdate_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                if (!_FillData())
                {
                    return;
                }

                if (MessageBox.Show("Are You Sure You Want To Update this Client ", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                if (_Client1.Save())
                {
                    MessageBox.Show($"Client Updated Successfully [{txtAccountNumber.Text}] ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Search;

                }
                else
                {
                    MessageBox.Show($"Failed to Update client [{txtAccountNumber.Text}] ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            if (_Mode == enMode.Search)
            {
                if (!Client.IsClientExist(txtAccountNumber.Text))
                {
                    MessageBox.Show($"Client Not Found[{txtAccountNumber.Text}] Try Another One", "Find", MessageBoxButtons.OK);
                    return;
                }

                _Client1 = Client.Find(txtAccountNumber.Text);

                txtFirstName.Text = _Client1.FirstName;
                txtLastName.Text = _Client1.LastName;
                txtEmail.Text = _Client1.Email;
                txtPhone.Text = _Client1.PhoneNumber;
                txtPinCode.Text = _Client1.PinCode;
                txtBalance.Text = _Client1.Balance.ToString();

                _DisabledJustAccountNumber();
                btnClear.Visible = true;
                btnSearchAndUpdate.Text = "Update";
                _Mode = enMode.Update;
            }


           

        }

        private void FrmUpdateClient_Load(object sender, EventArgs e)
        {
            _EnabledJustAccountNumber();
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
