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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Bank_Management_System
{
    public partial class FrmLogin : Form
    {
        
        int Attempts = 0;
        const int MaxAttempts = 3;
        enum enEyeMode { Hide, NotHide }
        enEyeMode _EyeMode;
        public FrmLogin()
        {
            InitializeComponent();



        }

        public async void Login()
        {
           
            Global.CurrentUser = User.FindUserByUsernameAndPassword(txtUsername.Text, txtPassword.Text);

            if (Global.CurrentUser != null)
            {
                User.AddNewLoginRegisters(Global.CurrentUser.Username, DateTime.Now);
                this.Hide();
                FrmMainMenu frm = new FrmMainMenu();
                frm.ShowDialog();


            }
            else
            {
                Attempts++;

                int Remaining = MaxAttempts - Attempts;

                if (Remaining > 0)
                {
                    lblAttempts.Text = $"Login Failed. Try again. " +
                                         $"You have {Remaining} trial(s) left.\a";
                    lblAttempts.Visible = true;
                    lblAttempts.ForeColor = Color.Red;
                }
                else
                {
                    lblAttempts.Text = "          Maximum login attempts exceeded.";
                    lblAttempts.ForeColor = Color.DarkRed;
                    MessageBox.Show(lblAttempts.Text, "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    await Task.Delay(1500);
                    Application.Exit();
                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (_EyeMode == enEyeMode.Hide)
            {
                btnHide.Image = Properties.Resources.icons8_millenium_eye_24;
                txtPassword.PasswordChar = '\0';
                _EyeMode = enEyeMode.NotHide;
            }
            else
            {
                btnHide.Image = Properties.Resources.icons8_closed_eye_24;
                txtPassword.PasswordChar = '*';
                _EyeMode = enEyeMode.Hide;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
