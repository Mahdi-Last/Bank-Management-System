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
    public partial class FrmTransferLogs : Form
    {
        public FrmTransferLogs()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTransactions());
        }

        private void _RefreshTransferLogs()
        {
            dgvAllTransferLogs.DataSource = TransferLogs.GetAllTransferLogs();
        }

        private void FrmTransferLogs_Load(object sender, EventArgs e)
        {
            FrmMainMenu._SetupDataGridViewStyle(dgvAllTransferLogs);
            _RefreshTransferLogs();
        }
    }
}
