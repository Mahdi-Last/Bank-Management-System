using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Management_System.Clients;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Transactions
{
    public partial class FrmDeposit : Form
    {
        enum enMode { Search, Send };
        enMode _Mode;
        Client _Client1;

        public FrmDeposit()
        {
            InitializeComponent();
        }

        private void FrmDeposit_Load(object sender, EventArgs e)
        {

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
            txtDepositAmount.Clear();

            btnClear.Visible = false;
            _Mode = enMode.Search;
            btnSearchAndSend.Text = "Search";
            btnClear.BackColor = Color.FromArgb(0, 123, 255);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTransactions());
        }

        private void btnSearchAndSend_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Send)
            {
                decimal depositAmount;
                if (!decimal.TryParse(txtDepositAmount.Text, out depositAmount))
                {
                    MessageBox.Show("Please enter a valid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(MessageBox.Show(
                    $"Are you sure you want to deposit {depositAmount:C} to account [{_Client1.AccountNumber}]?",
                    "Confirm Deposit",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                
 

                if (!Client.Deposit(txtAccountNumber.Text, depositAmount))
                {
                    MessageBox.Show("Deposit failed. The amount must be a positive number. Please try again.", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Amount Deposited Successfully", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);

     
                _Client1 = Client.Find(txtAccountNumber.Text);
                txtBalance.Text = _Client1.Balance.ToString();

                btnClear.PerformClick();
                return;
            }

            if (_Mode == enMode.Search)
            {
                if (!Client.IsClientExist(txtAccountNumber.Text))
                {
                    MessageBox.Show($"Client Not Found [{txtAccountNumber.Text}] Try Another One", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _Client1 = Client.Find(txtAccountNumber.Text);

                txtAccountNumber.Text = _Client1.AccountNumber;
                txtFirstName.Text = _Client1.FirstName;
                txtLastName.Text = _Client1.LastName;
                txtEmail.Text = _Client1.Email;
                txtPhone.Text = _Client1.PhoneNumber;
                txtPinCode.Text = _Client1.PinCode;
                txtBalance.Text = _Client1.Balance.ToString();

                _Mode = enMode.Send;
                btnSearchAndSend.Text = "Send";
                btnSearchAndSend.BackColor = Color.FromArgb(40, 167, 69);
                btnClear.Visible = true;
            }
        }

        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
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

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPinCode_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
