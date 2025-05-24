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
using Bank_Management_System.Forms.Home;
using Bank_Management_System.Forms.LoginRegisters;
using Bank_Management_System.Forms.MyScreen;
using Bank_Management_System.Forms.Transactions;
using Bank_Management_System.Forms.Users;
using BankBusinessLayer;

namespace Bank_Management_System
{
    public partial class FrmMainMenu : Form
    {

        private Button _CurrentButton;
        private   Form _ActiveForm;
        public static Panel MainPanel;

        public enum enMainMenuPermissions {enAll = -1, enHome = 1, enClients = 2, enUsers = 4, enTransactions = 8, enLoginRegisters = 16 }


        public FrmMainMenu()
        {
            InitializeComponent();
        }

        public static bool CheckPermissions(enMainMenuPermissions permissions)
        {

            if ((Global.CurrentUser.Permission & (int)enMainMenuPermissions.enAll) == (int)enMainMenuPermissions.enAll)
            {
                return true;
            }

            if ((permissions & (enMainMenuPermissions)Global.CurrentUser.Permission) == permissions)
            {
                return true;
            }
            else
                return false;
        }

        public void DisableButtonsIfNoAccess()
        {
            if(CheckPermissions(enMainMenuPermissions.enAll))
            {
                return;
            }

            if (!CheckPermissions(enMainMenuPermissions.enHome))
            {
                btnHome.Enabled = false;
            }

            if (!CheckPermissions(enMainMenuPermissions.enClients))
            {
                btnClients.Enabled = false;
            }

            if (!CheckPermissions(enMainMenuPermissions.enUsers))
            {
                btnUsers.Enabled = false;
            }

            if (!CheckPermissions(enMainMenuPermissions.enTransactions))
            {
                btnTransactions.Enabled = false;
            }

            if (!CheckPermissions(enMainMenuPermissions.enLoginRegisters))
            {
                btnLoginRegisters.Enabled = false;
            }

        }

        public static void _SetupDataGridViewStyle(DataGridView dgv)
        {
            
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.GridColor = Color.Gainsboro; 

          
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgv.DefaultCellStyle.BackColor = Color.White;

          
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 130, 180); 
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

           
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 100, 150); 
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230); 
            dgv.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);

           
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

         
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }


        private void _ActivateButton(Button button)
        {
            if (_CurrentButton != null) {

                _CurrentButton.BackColor = Color.SteelBlue;
                _CurrentButton.ForeColor = Color.White;
               // _CurrentButton.Font = new Font(_CurrentButton.Font, FontStyle.Regular);

            }

            _CurrentButton = button;


            _CurrentButton.BackColor = Color.FromArgb(255, 39, 73, 109);
            _CurrentButton.ForeColor = Color.White;
           // _CurrentButton.Font = new Font(_CurrentButton.Font, FontStyle.Bold);

        }

     
        static public void OpenChildForm( Form ChildForm)
        {
            // Check if the form is already loaded, then exit the function
            if (MainPanel.Controls.Count > 0 && MainPanel.Controls[0].GetType() == ChildForm.GetType())
                return;

            // If MainPanel contains an old element, dispose of it
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            

            ChildForm.TopLevel = false; 
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void HandleMenuClick(Button button, Form form)
        {
            _ActivateButton(button);
            OpenChildForm(form);
        }


        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            MainPanel = plMainPanel;

            if (CheckPermissions(enMainMenuPermissions.enHome))
            {
                _ActivateButton(btnHome);
                OpenChildForm(new FrmHome());
            }

          timer1.Start();
            lblUsername.Text = Global.CurrentUser.Username;
            DisableButtonsIfNoAccess();
            
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
       

            HandleMenuClick(btnUsers, new FrmUsers());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {

            HandleMenuClick(btnTransactions, new FrmTransactions());
        }

        private void btnLoginRegisters_Click(object sender, EventArgs e)
        {
            

            HandleMenuClick(btnLoginRegisters, new FrmLoginRegisters());
        }

      

        private void btnClients_Click_1(object sender, EventArgs e)
        {
            

            HandleMenuClick(btnClients, new FrmClients());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
         
            HandleMenuClick(btnHome, new FrmHome());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.CurrentUser = null;
            Application.Restart();
        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMyScreen frm = new FrmMyScreen();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Left + 10, this.Top + 10);
            frm.ShowDialog();
        }

        private void plMyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
