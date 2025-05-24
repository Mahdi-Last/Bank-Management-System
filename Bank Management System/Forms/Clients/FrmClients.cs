using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Management_System.Forms.Clients;
using BankBusinessLayer;

namespace Bank_Management_System.Clients
{
    public partial class FrmClients : Form
    {

        public enum enClientsPermissions
        {
            
            enClientsList = 32768,      
            enAddClient = 65536,        
            enFindClient = 131072,       
            enDeleteClient = 262144,     
            enUpdateClient = 524288
        }

        public FrmClients()
        {
            InitializeComponent();
        }

        public bool CheckPermissions(enClientsPermissions Permission)
        {
            return ((Permission & (enClientsPermissions)Global.CurrentUser.Permission) == Permission);
        }

        public void DisableButtonsIfNoAccess(ref int Count)
        {
            if (!CheckPermissions(enClientsPermissions.enClientsList))
            {
                btnClinetsList.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enClientsPermissions.enAddClient))
            {
                btnAddClient.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enClientsPermissions.enFindClient))
            {
                btnFindClient.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enClientsPermissions.enDeleteClient))
            {
                btnDeleteClient.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enClientsPermissions.enUpdateClient))
            {
                btnUpdateClient.Enabled = false;
                Count++;
            }
        }



        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmUpdateClient());
        }

        private void btnClinetsList_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmClientsList());

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmAddNewClient());
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmFindClient());
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmDeleteClient());
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            int Count = 0;
            DisableButtonsIfNoAccess(ref Count);

            if (Count == 5)
            {
                lbl.Visible = true;
            }
        }

    }
}
