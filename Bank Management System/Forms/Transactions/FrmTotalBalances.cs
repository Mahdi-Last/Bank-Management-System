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

namespace Bank_Management_System.Forms.Transactions
{
    public partial class FrmTotalBalances : Form
    {
        public FrmTotalBalances()
        {
            InitializeComponent();
           // _RefreshBalances();
        }

        private void _RefreshBalances()
        {
            dgvTotalBalances.DataSource = Client.GetAllBalances();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTransactions());
        }

        private void FrmTotalBalances_Load(object sender, EventArgs e)
        {
            FrmMainMenu._SetupDataGridViewStyle(dgvTotalBalances);
            _RefreshBalances();


        }

      
    }
}
