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
using static Bank_Management_System.Forms.Users.FrmUsers;

namespace Bank_Management_System.Forms.Transactions
{
    public partial class FrmTransactions : Form
    {

        public enum enTransactions { enDeposit = 1024, enWithdraw = 2048, enTotalBalances = 4096, enTransfer = 8192, enTransferLogs = 16384 }

        public FrmTransactions()
        {
            InitializeComponent();
        }

        public bool CheckPermissions(enTransactions Permission)
        {
            if ((Permission & (enTransactions)Global.CurrentUser.Permission) == Permission)
            {
                return true;
            }

            return false;
        }

        public void DisableButtonsIfNoAccess(ref int Count)
        {

            if (!CheckPermissions(enTransactions.enDeposit))
            {
                btnDeposit.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enTransactions.enWithdraw))
            {
                btnWithdraw.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enTransactions.enTotalBalances))
            {
                btnTotalBalances.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enTransactions.enTransfer))
            {
                btnTransfer.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enTransactions.enTransferLogs))
            {
                btnTransferLog.Enabled = false;
                Count++;
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmDeposit());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmWithdraw());
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTotalBalances());
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTransfer());
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmTransferLogs());
        }

        private void FrmTransactions_Load(object sender, EventArgs e)
        {
            int Count  = 0;
            DisableButtonsIfNoAccess(ref Count);

            if (Count == 5)
            {
                lbl.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
