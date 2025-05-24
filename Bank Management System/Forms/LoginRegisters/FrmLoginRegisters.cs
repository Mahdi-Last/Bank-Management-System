using System;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.LoginRegisters
{
    public partial class FrmLoginRegisters : Form
    {
        public FrmLoginRegisters()
        {
            InitializeComponent();
        }

        private void _RefreshLoginRegisters()
        {
            dgvAllLoginRegisters.DataSource = User.GetAllLoginRegisters();
        }

        private void FrmLoginRegisters_Load(object sender, EventArgs e)
        {
            FrmMainMenu._SetupDataGridViewStyle(dgvAllLoginRegisters);
            _RefreshLoginRegisters();

        }
    }
}
