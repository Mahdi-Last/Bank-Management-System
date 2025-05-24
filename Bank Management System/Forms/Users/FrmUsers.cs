using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Users
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        public enum enManageUsers { enUsersList = 32, enFindUser = 64,  enDeleteUser = 128 , enAddUser = 256, enUpdateUser = 512}

        public bool CheckPermissions(enManageUsers Permission)
        {
           if((Permission & (enManageUsers) Global.CurrentUser.Permission ) == Permission)
            {
                return true;
            }

            return false;
        }

        public void DisableButtonsIfNoAccess(ref int Count)
        {
           
            if (!CheckPermissions(enManageUsers.enUsersList))
            {
                btnClinetsList.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enManageUsers.enAddUser))
            {
                btnAddUser.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enManageUsers.enFindUser))
            {
                btnFindUser.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enManageUsers.enDeleteUser))
            {
                btnDeleteUser.Enabled = false;
                Count++;
            }

            if (!CheckPermissions(enManageUsers.enUpdateUser))
            {
                btnUpdateUser.Enabled = false;
                Count++;
            }
        }
        private void btnClinetsList_Click(object sender, EventArgs e)
        {
          
            
            FrmMainMenu.OpenChildForm(new FrmUsersList());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmUpdateUser());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmAddNewUser());
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmFindUser());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmDeleteUser());
        }

        private void FrmUsers_Load(object sender, EventArgs e)
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
