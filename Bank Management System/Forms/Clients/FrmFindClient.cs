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
   
    public partial class FrmFindClient : Form
    {

        enum enMode { Search, Clear };
         enMode _Mode;
        Client _Client1;

        public FrmFindClient()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Search)
            {
               if(!Client.IsClientExist(txtAccountNumber.Text))
                {
                    MessageBox.Show($"Client Not Found [{txtAccountNumber.Text}] Try Another One", "Find", MessageBoxButtons.OK);
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


            }


            _Mode = enMode.Clear;
            btnSearch.Enabled = false;
            btnClear.Visible = true;
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

            btnClear.Visible = false;
            _Mode = enMode.Search;
            btnSearch.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmClients());
        }

        private void FrmFindClient_Load(object sender, EventArgs e)
        {

        }
    }
}
