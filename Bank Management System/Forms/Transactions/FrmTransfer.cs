using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Transactions
{
    public partial class FrmTransfer : Form

    {

        enum enMode { Search, Send}
        enMode _Mode;
        Client _Client1;
        Client _Client2;

        enum enClientNotExistsAndExists{ eClient1, eClient2 , eTwoClientsNotExists, eTwoClientsIsExists }

        enClientNotExistsAndExists _Client;
        public FrmTransfer()
        {
            InitializeComponent();
        }

   
        public void PlaceHolders()
        {
            clsPlaceholderManager.SetPlaceholder(txtFromAccountNumber, "Enter Account Number");
            clsPlaceholderManager.SetPlaceholder(txtFirstNameFrom, "FirstName");
            clsPlaceholderManager.SetPlaceholder(txtLastNameFrom, "LastName");
            clsPlaceholderManager.SetPlaceholder(txtPhoneFrom, "PhoneNumber");
            clsPlaceholderManager.SetPlaceholder(txtEmailFrom, "Email");
            clsPlaceholderManager.SetPlaceholder(txtBalanceFrom, "Balance");

            clsPlaceholderManager.SetPlaceholder(txtToAccountNumber, "Enter Account Number");
            clsPlaceholderManager.SetPlaceholder(txtFirstNameTo, "FirstName");
            clsPlaceholderManager.SetPlaceholder(txtLastNameTo, "LastName");
            clsPlaceholderManager.SetPlaceholder(txtPhoneTo, "PhoneNumber");
            clsPlaceholderManager.SetPlaceholder(txtEmailTo, "Email");
            clsPlaceholderManager.SetPlaceholder(txtBalanceTo, "Balance");

            clsPlaceholderManager.SetPlaceholder(txtTransferAmount, "Enter Amount To Transfer");
        }


        private enClientNotExistsAndExists _WhichClientExists()
        {
            bool client1Exists = Client.IsClientExist(clsPlaceholderManager.GetText(txtFromAccountNumber));
            bool client2Exists = Client.IsClientExist(clsPlaceholderManager.GetText(txtToAccountNumber));

            if (!client1Exists && !client2Exists)
                return enClientNotExistsAndExists.eTwoClientsNotExists;

            if (!client1Exists)
                return enClientNotExistsAndExists.eClient1;

            if (!client2Exists)
                return enClientNotExistsAndExists.eClient2;

            return enClientNotExistsAndExists.eTwoClientsIsExists;
        }

        private void btnSearchAndSend_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Search)
            {
                string fromAcc = clsPlaceholderManager.GetText(txtFromAccountNumber);
                string toAcc = clsPlaceholderManager.GetText(txtToAccountNumber);

                bool client1Exists = Client.IsClientExist(fromAcc);
                bool client2Exists = Client.IsClientExist(toAcc);

                if (!client1Exists && !client2Exists)
                {
                    MessageBox.Show($"Both account numbers [{fromAcc}] and [{toAcc}] were not found.", "Error");
                    return;
                }
                if (!client1Exists)
                {
                    MessageBox.Show($"From Account Number [{fromAcc}] was not found!", "Error");
                    return;
                }
                if (!client2Exists)
                {
                    MessageBox.Show($"To Account Number [{toAcc}] was not found!", "Error");
                    return;
                }

                _Client1 = Client.Find(fromAcc);
                _Client2 = Client.Find(toAcc);
                _FillData();

                txtFromAccountNumber.Enabled = false;
                txtToAccountNumber.Enabled = false;

                btnSearchAndSend.Text = "Send";
                _Mode = enMode.Send;
                txtTransferAmount.Enabled = true;
                btnClear.Visible = true;
                btnSearchAndSend.BackColor = Color.FromArgb(40, 167, 69);
            }
            else if (_Mode == enMode.Send)
            {
                string fromAcc = clsPlaceholderManager.GetText(txtFromAccountNumber);
                string toAcc = clsPlaceholderManager.GetText(txtToAccountNumber);
                decimal amount;

                if (fromAcc == toAcc)
                {
                    MessageBox.Show("Error: You cannot transfer to the same account.", "Invalid Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(clsPlaceholderManager.GetText(txtTransferAmount), out amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid transfer amount.", "Invalid Amount");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to perform this transfer?", "Confirm Transfer", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                
                if (!_Client1.Transfer(fromAcc, toAcc, amount))
                {
                    MessageBox.Show("Transfer failed. Please check the balance and try again.", "Error");
                    return;
                }

                MessageBox.Show($"Amount ${amount} transferred successfully!", "Transferred", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TransferLogs log = new TransferLogs();
                log.Date = DateTime.Now;
                log.AccountForom = fromAcc;
                log.AccountTo = toAcc;
                log.PerformedBy = Global.CurrentUser.Username;
                log.Amount = amount;
                log.AddTrnasferLog();

                btnClear.PerformClick();
              
               
            }
        }

        private void _FillData()
        {
           txtFirstNameFrom.Text = _Client1.FirstName;
            txtLastNameFrom.Text = _Client1.LastName;
            txtPhoneFrom.Text = _Client1.PhoneNumber;
            txtEmailFrom.Text = _Client1.Email;
            txtBalanceFrom.Text = _Client1.Balance.ToString();

            txtFirstNameTo.Text = _Client2.FirstName;
            txtLastNameTo.Text = _Client2.LastName;
            txtPhoneTo.Text = _Client2.PhoneNumber;
            txtEmailTo.Text = _Client2.Email;
            txtBalanceTo.Text = _Client2.Balance.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTransactions());
        }

        private void FrmTransfer_Load(object sender, EventArgs e)
        {
            PlaceHolders();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFromAccountNumber.Enabled = true;
            txtToAccountNumber.Enabled = true;

            PlaceHolders();

            btnClear.Visible = false;
            txtTransferAmount.Enabled = false;
            btnSearchAndSend.Text = "Search";
            btnSearchAndSend.BackColor = Color.FromArgb(0, 123, 255);
            _Mode = enMode.Search;

           


        }
    }
}
