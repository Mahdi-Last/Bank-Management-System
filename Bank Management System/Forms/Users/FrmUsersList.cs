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

namespace Bank_Management_System.Forms.Users
{
    public partial class FrmUsersList : Form
    {
        public FrmUsersList()
        {
            InitializeComponent();
            _RefreshUsers();
        }
        private void _RefreshUsers()
        {
            dgvAllUsers.DataSource = User.GetAllUsers();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu.OpenChildForm(new FrmUsers());
        }

        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            FrmMainMenu._SetupDataGridViewStyle(dgvAllUsers);
            _RefreshUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Username = (string)dgvAllUsers.CurrentRow.Cells[4].Value;

           

            FrmUsers frmUsers = new FrmUsers();

            if(!frmUsers.CheckPermissions(FrmUsers.enManageUsers.enDeleteUser))
            {
                MessageBox.Show("Access Denied you do not have permission to delete User [" + Username + "]", "Permision", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Username == "Admin")
            {
                MessageBox.Show("You cannot delete [" + Username + "]", "Delete Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete User [" + Username + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

              
                if (User.DeleteUser(Username))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshUsers();
                }

                else
                    MessageBox.Show("User is not deleted.");
            }
        }
    }
}
