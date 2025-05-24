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
    public partial class FrmWithdraw : Form
    {

        enum enMode { Search, Send };
        enMode _Mode;
        Client _Client1;

        public FrmWithdraw()
        {
            InitializeComponent();
        }

        private void btnSearchAndSend_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Send)
            {
                decimal WithdrawAmount;
                if (!decimal.TryParse(txtWithdrawAmount.Text, out WithdrawAmount) )
                {
                    MessageBox.Show("Please enter a valid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show($"Are you sure you want to Withdraw {WithdrawAmount:C} to account [{_Client1.AccountNumber}]?", "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }



                if (!Client.Withdraw(txtAccountNumber.Text,_Client1.Balance, WithdrawAmount))
                {
                    MessageBox.Show("Withdrawal failed. The amount must be positive and not exceed the current balance. Please try again.", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Amount Withdrawn Successfully", "Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Clear();
            txtPinCode.Clear();
            txtBalance.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtWithdrawAmount.Clear();

            btnClear.Visible = false;
            _Mode = enMode.Search;
            btnSearchAndSend.Text = "Search";
            btnClear.BackColor = Color.FromArgb(0, 123, 255);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTransactions());
        }

        private void FrmWithdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
