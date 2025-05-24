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

namespace Bank_Management_System.Forms.Clients
{
    public partial class FrmDeleteClient : Form
    {

        enum enMode { Search, Delete};
        enMode _Mode;
        Client _Client1;
        public FrmDeleteClient()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmClients());
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

            txtAccountNumber.Enabled = true;
            btnSearchAndDelete.BackColor = Color.FromArgb(0, 123, 255);
            btnSearchAndDelete.Text = "Search";
            btnClear.Visible = false;
            _Mode = enMode.Search;
            txtAccountNumber.Focus();
        }

        private void EnabledJustAccountNumber()
        {
            txtAccountNumber.Enabled = true;
            txtPinCode.Enabled = false;
            txtBalance.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;

        }

        private void _Delete()
        {
            if (Client.DeleteClient(_Client1.AccountNumber))
            {
                MessageBox.Show("Client Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Failed to delete client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSearchAndDelete_Click(object sender, EventArgs e)
        {
            
            if(_Mode == enMode.Delete)
            {
                if(MessageBox.Show("Are you sure you want to delete this client ", "Delete", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _Delete();

                    btnClear.PerformClick();
                    return;
                }

                return;
            }

            if (!Client.IsClientExist(txtAccountNumber.Text))
            {
                MessageBox.Show("Client does not exist!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            txtAccountNumber.Enabled = false;
            _Mode = enMode.Delete;
                btnSearchAndDelete.Text = "Delete";
            btnSearchAndDelete.BackColor = Color.FromArgb(220, 53, 69);
                btnClear.Visible = true;
              
          

        }

        private void FrmDeleteClient_Load(object sender, EventArgs e)
        {
            EnabledJustAccountNumber();
        }
    }
}
