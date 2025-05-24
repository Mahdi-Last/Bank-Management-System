using System;
using System.Windows.Forms;
using Bank_Management_System.Clients;
using Bank_Management_System.Forms.Users;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Clients
{
    public partial class FrmClientsList : Form
    {
        public FrmClientsList()
        {
            
            InitializeComponent();
            _RefreshClients();
        }

        private void _RefreshClients()
        {
            dgvAllClients.DataSource = Client.GetAllClients();
        }

        private void FrmClientsList_Load(object sender, EventArgs e)
        {
            FrmMainMenu._SetupDataGridViewStyle(dgvAllClients);
            _RefreshClients();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmClients());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string AccountNumber = (string)dgvAllClients.CurrentRow.Cells[0].Value;

            FrmClients frmUsers = new FrmClients();

            if (!frmUsers.CheckPermissions(FrmClients.enClientsPermissions.enDeleteClient))
            {
                MessageBox.Show("Access Denied you do not have permission to delete Client [" + AccountNumber + "]", "Permision", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete Client [" + AccountNumber + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {


                if (Client.DeleteClient(AccountNumber))
                {
                    MessageBox.Show("Client Deleted Successfully.");
                    _RefreshClients();
                }

                else
                    MessageBox.Show("Client is not deleted.");
            }
        }
    }
}
    

