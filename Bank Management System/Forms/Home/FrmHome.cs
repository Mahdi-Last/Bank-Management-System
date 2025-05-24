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

namespace Bank_Management_System.Forms.Home
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            lblTotalBalances.Text = Client.GetTotalBalances().ToString();
            lblTotalClients.Text = Client.GetTotalClients().ToString();

            lblTotalLoginRegisters.Text = User.GetTotalLoginRegisters().ToString();
            lblTotalUsers.Text = User.GetTotalUsers().ToString();

            lblTotalTransfers.Text = TransferLogs.GetTotalTransferLogs().ToString();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalBalances_Click(object sender, EventArgs e)
        {

        }
    }
}
                                                                                                                                                                                                                                     