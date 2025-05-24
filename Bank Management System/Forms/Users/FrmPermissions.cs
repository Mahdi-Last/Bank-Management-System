using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BankBusinessLayer;

namespace Bank_Management_System.Forms.Users
{
    public partial class FrmPermissions : Form
    {
       public  CheckBox[] AllCheckboxes;
       

        public static  int Permission = 0;
        public enum enMainMenuPermissions { enAll = -1, enHome = 1, enClients = 2, enUsers = 4, enTransactions = 8, enLoginRegisters = 16 }
        public enum enManageUsers { enUsersList = 32, enFindUser = 64, enDeleteUser = 128, enAddUser = 256, enUpdateUser = 512 }
        public enum enTransactions { enDeposit = 1024, enWithdraw = 2048, enTotalBalances = 4096, enTransfer = 8192, enTransferLogs = 16384 }

        public enum enClientsPermissions
        {

            enClientsList = 32768,
            enAddClient = 65536,
            enFindClient = 131072,
            enDeleteClient = 262144,
            enUpdateClient = 524288
        }

        public void SetPermissionsForMainMenue()
        {
            if (cbHome.Checked)
                Permission |= (int)enMainMenuPermissions.enHome;
            if (cbClientsSection.Checked)
                Permission |= (int)enMainMenuPermissions.enClients;
            if (cbUsersSection.Checked)
                Permission |= (int)enMainMenuPermissions.enUsers;
            if (cbTransactionsSection.Checked)
                Permission |= (int)enMainMenuPermissions.enTransactions;
            if (cbLoginRegisters.Checked)
                Permission |= (int)enMainMenuPermissions.enLoginRegisters;
        }

        public void SetPermissionsForManagesUsers()
        {
            if (cbUsersList.Checked)
                Permission |= (int)enManageUsers.enUsersList;
            if (cbFindUser.Checked)
                Permission |= (int)enManageUsers.enFindUser;
            if (cbDeleteUser.Checked)
                Permission |= (int)enManageUsers.enDeleteUser;
            if (cbAddUser.Checked)
                Permission |= (int)enManageUsers.enAddUser;
            if (cbUpdateUser.Checked)
                Permission |= (int)enManageUsers.enUpdateUser;
        }

        public void SetPermissionsForClients()
        {
            if (cbClientsList.Checked)
                Permission |= (int)enClientsPermissions.enClientsList;
            if (cbAddClient.Checked)
                Permission |= (int)enClientsPermissions.enAddClient;
            if (cbFindClient.Checked)
                Permission |= (int)enClientsPermissions.enFindClient;
            if (cbDeleteClient.Checked)
                Permission |= (int)enClientsPermissions.enDeleteClient;
            if (cbUpdateClient.Checked)
                Permission |= (int)enClientsPermissions.enUpdateClient;
        }
        public void SetPermissionsForTransaction()
        {
        
            if (cbDeposit.Checked)
                Permission |= (int)enTransactions.enDeposit;
            if (cbWithdraw.Checked)
                Permission |= (int)enTransactions.enWithdraw;
            if (cbTotalBalances.Checked)
                Permission |= (int)enTransactions.enTotalBalances;
            if (cbTransfer.Checked)
                Permission |= (int)enTransactions.enTransfer;
            if (cbTransferLog.Checked)
                Permission |= (int)enTransactions.enTransferLogs;

        }
        public void UnCheckedAll()
        {
            _isUpdatingCheckBoxes = true;  // تعطيل الاستجابة للأحداث مؤقتاً

            foreach (CheckBox cb in AllCheckboxes)
            {
                cb.Checked = false;
            }

            _isUpdatingCheckBoxes = false;  // تفعيل الاستجابة مجددًا
        }


        public bool HasPermission(int userPermissions, int specificPermission)
        {
            return (userPermissions & specificPermission) == specificPermission;
        }


        public void LoadPermissionsFromValue(int permission)
        {
           
            cbHome.Checked = HasPermission(permission, (int)enMainMenuPermissions.enHome);
            cbClientsSection.Checked = HasPermission(permission, (int)enMainMenuPermissions.enClients);
            cbUsersSection.Checked = HasPermission(permission, (int)enMainMenuPermissions.enUsers);
            cbTransactionsSection.Checked = HasPermission(permission, (int)enMainMenuPermissions.enTransactions);
            cbLoginRegisters.Checked = HasPermission(permission, (int)enMainMenuPermissions.enLoginRegisters);

         
            cbUsersList.Checked = HasPermission(permission, (int)enManageUsers.enUsersList);
            cbFindUser.Checked = HasPermission(permission, (int)enManageUsers.enFindUser);
            cbDeleteUser.Checked = HasPermission(permission, (int)enManageUsers.enDeleteUser);
            cbAddUser.Checked = HasPermission(permission, (int)enManageUsers.enAddUser);
            cbUpdateUser.Checked = HasPermission(permission, (int)enManageUsers.enUpdateUser);

          
            cbDeposit.Checked = HasPermission(permission, (int)enTransactions.enDeposit);
            cbWithdraw.Checked = HasPermission(permission, (int)enTransactions.enWithdraw);
            cbTotalBalances.Checked = HasPermission(permission, (int)enTransactions.enTotalBalances);
            cbTransfer.Checked = HasPermission(permission, (int)enTransactions.enTransfer);
            cbTransferLog.Checked = HasPermission(permission, (int)enTransactions.enTransferLogs);

           
            cbClientsList.Checked = HasPermission(permission, (int)enClientsPermissions.enClientsList);
            cbAddClient.Checked = HasPermission(permission, (int)enClientsPermissions.enAddClient);
            cbFindClient.Checked = HasPermission(permission, (int)enClientsPermissions.enFindClient);
            cbDeleteClient.Checked = HasPermission(permission, (int)enClientsPermissions.enDeleteClient);
            cbUpdateClient.Checked = HasPermission(permission, (int)enClientsPermissions.enUpdateClient);

            cbFullAccess.Checked = IsCheckedAll();
        }


        public bool IsCheckedAll()
        {
           

            foreach (CheckBox cb in AllCheckboxes)
            {
                if (!cb.Checked)
                    return false;
            }

            return true;
        }

        public void SetPermissionsFormUI()
        {
            Permission = 0;

           if(cbFullAccess.Checked)
            {
                Permission = -1;
                return;
            }

          
            SetPermissionsForMainMenue();

            if (cbClientsSection.Checked)
                SetPermissionsForClients();

            if (cbUsersSection.Checked)
                SetPermissionsForManagesUsers();

            if (cbTransactionsSection.Checked)
                SetPermissionsForTransaction();

        }


        public FrmPermissions(int Permissions)
        {
            InitializeComponent();
            Permission = Permissions;
            AllCheckboxes = new CheckBox[]
                {

                    cbHome,
                    cbClientsSection,
                    cbUsersSection,
                    cbTransactionsSection,
                    cbLoginRegisters,
                    cbUsersList,
                    cbFindUser,
                    cbDeleteUser,
                    cbAddUser,
                    cbUpdateUser,
                    cbDeposit,
                    cbWithdraw,
                    cbTotalBalances,
                    cbTransfer,
                    cbTransferLog,
                    cbClientsList,
                    cbAddClient,
                    cbFindClient,
                    cbDeleteClient,
                    cbUpdateClient


        };

        }

        private void FrmPermissions_Load(object sender, EventArgs e)
        {
            
            
            LoadPermissionsFromValue(Permission);
            _CheckBoxesChanged();

            if (cbFullAccess.Checked)
            {
                if(!IsCheckedAll())
                {
                    cbFullAccess.Checked = false;
                }
            }

            
            cbClientsSection.CheckedChanged += cbClientsSection_CheckedChanged;

            cbUsersSection.CheckedChanged += cbUsersSection_CheckedChanged;
            cbTransactionsSection.CheckedChanged += cbTransactionsSection_CheckedChanged;

            SetupSubCheckboxesCheckedChanged();

        }

        private void _CheckBoxesChanged()
        {
  
            foreach (CheckBox cb in AllCheckboxes)
            {
                cb.CheckedChanged += CheckBoxChangedDisableFullAccessIfUnChecked;
            }

            cbFullAccess.CheckedChanged += cbFullAccess_CheckedChanged;

        }

        // لمنع حلقات لا نهائية عند تحديث حالة شيك بوكسيس
        bool _isUpdatingCheckBoxes = false;
        private void CheckBoxChangedDisableFullAccessIfUnChecked(object sender, EventArgs e)
        {
            if (cbFullAccess == null) return;

            CheckBox changedCheckBox = (CheckBox)sender;


            if (changedCheckBox == null)
                return;

            if (!changedCheckBox.Checked && cbFullAccess.Checked)
            {
                _isUpdatingCheckBoxes = true;
                cbFullAccess.Checked = false;
                _isUpdatingCheckBoxes = false;
            }
        }

        private void cbFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (_isUpdatingCheckBoxes) return;

            _isUpdatingCheckBoxes = true;

            bool check = cbFullAccess.Checked;

      

            foreach (CheckBox cb in AllCheckboxes)
            {
                cb.Checked = check;
            }

            SetPermissionsFormUI();

            _isUpdatingCheckBoxes = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetPermissionsFormUI();
            this.Close();
        }

        private void btnUnCheckedAll_Click(object sender, EventArgs e)
        {
            UnCheckedAll();
            cbFullAccess.Checked = false;
            Permission = 0;
        }

        private void cbClientsSection_CheckedChanged(object sender, EventArgs e)
        {
            if(!cbClientsSection.Checked)
            {
                cbClientsList.Checked = false;
                cbAddClient.Checked = false;
                cbDeleteClient.Checked = false;
                cbUpdateClient.Checked = false;
                cbFindClient.Checked = false;
                SetPermissionsFormUI();
            }
        }

        private void cbUsersSection_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbUsersSection.Checked)
            {
                cbUsersList.Checked = false;
                cbAddUser.Checked = false;
                cbDeleteUser.Checked = false;
                cbUpdateUser.Checked = false;
                cbFindUser.Checked = false;
                SetPermissionsFormUI();
            }
        }

        private void cbTransactionsSection_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbTransactionsSection.Checked)
            {
                cbTransferLog.Checked = false;
                cbTransfer.Checked = false;
                cbDeposit.Checked = false;
                cbWithdraw.Checked = false;
                cbTotalBalances.Checked = false;
                SetPermissionsFormUI();
            }
        }


        // In Load Form
        private void SetupSubCheckboxesCheckedChanged()
        {
            // Clients
            cbClientsList.CheckedChanged -= SubCheckbox_CheckedChanged_ClientSection;
            cbClientsList.CheckedChanged += SubCheckbox_CheckedChanged_ClientSection;

            cbAddClient.CheckedChanged -= SubCheckbox_CheckedChanged_ClientSection;
            cbAddClient.CheckedChanged += SubCheckbox_CheckedChanged_ClientSection;

            cbFindClient.CheckedChanged -= SubCheckbox_CheckedChanged_ClientSection;
            cbFindClient.CheckedChanged += SubCheckbox_CheckedChanged_ClientSection;

            cbDeleteClient.CheckedChanged -= SubCheckbox_CheckedChanged_ClientSection;
            cbDeleteClient.CheckedChanged += SubCheckbox_CheckedChanged_ClientSection;

            cbUpdateClient.CheckedChanged -= SubCheckbox_CheckedChanged_ClientSection;
            cbUpdateClient.CheckedChanged += SubCheckbox_CheckedChanged_ClientSection;

            // Users
            cbUsersList.CheckedChanged -= SubCheckbox_CheckedChanged_UserSection;
            cbUsersList.CheckedChanged += SubCheckbox_CheckedChanged_UserSection;

            cbFindUser.CheckedChanged -= SubCheckbox_CheckedChanged_UserSection;
            cbFindUser.CheckedChanged += SubCheckbox_CheckedChanged_UserSection;

            cbDeleteUser.CheckedChanged -= SubCheckbox_CheckedChanged_UserSection;
            cbDeleteUser.CheckedChanged += SubCheckbox_CheckedChanged_UserSection;

            cbAddUser.CheckedChanged -= SubCheckbox_CheckedChanged_UserSection;
            cbAddUser.CheckedChanged += SubCheckbox_CheckedChanged_UserSection;

            cbUpdateUser.CheckedChanged -= SubCheckbox_CheckedChanged_UserSection;
            cbUpdateUser.CheckedChanged += SubCheckbox_CheckedChanged_UserSection;

            // Trnasactions
            cbDeposit.CheckedChanged -= SubCheckbox_CheckedChanged_TransactionSection;
            cbDeposit.CheckedChanged += SubCheckbox_CheckedChanged_TransactionSection;

            cbWithdraw.CheckedChanged -= SubCheckbox_CheckedChanged_TransactionSection;
            cbWithdraw.CheckedChanged += SubCheckbox_CheckedChanged_TransactionSection;

            cbTotalBalances.CheckedChanged -= SubCheckbox_CheckedChanged_TransactionSection;
            cbTotalBalances.CheckedChanged += SubCheckbox_CheckedChanged_TransactionSection;

            cbTransfer.CheckedChanged -= SubCheckbox_CheckedChanged_TransactionSection;
            cbTransfer.CheckedChanged += SubCheckbox_CheckedChanged_TransactionSection;

            cbTransferLog.CheckedChanged -= SubCheckbox_CheckedChanged_TransactionSection;
            cbTransferLog.CheckedChanged += SubCheckbox_CheckedChanged_TransactionSection;
        }

        private void SetupSectionCheckboxesCheckedChanged()
        {
            cbClientsSection.CheckedChanged -= cbClientsSection_CheckedChanged;
            cbClientsSection.CheckedChanged += cbClientsSection_CheckedChanged;

            cbUsersSection.CheckedChanged -= cbUsersSection_CheckedChanged;
            cbUsersSection.CheckedChanged += cbUsersSection_CheckedChanged;

            cbTransactionsSection.CheckedChanged -= cbTransactionsSection_CheckedChanged;
            cbTransactionsSection.CheckedChanged += cbTransactionsSection_CheckedChanged;

        }

        // تعاريف الدوال التي تضمن تفعيل القسم الرئيسي عند تفعيل فرعي
        private void SubCheckbox_CheckedChanged_ClientSection(object sender, EventArgs e)
        {
            if (!_isUpdatingCheckBoxes && ((CheckBox)sender).Checked && !cbClientsSection.Checked)
            {
                cbClientsSection.Checked = true;
            }
        }

        private void SubCheckbox_CheckedChanged_UserSection(object sender, EventArgs e)
        {
            if (!_isUpdatingCheckBoxes && ((CheckBox)sender).Checked && !cbUsersSection.Checked)
            {
                cbUsersSection.Checked = true;
            }
        }

        private void SubCheckbox_CheckedChanged_TransactionSection(object sender, EventArgs e)
        {
            if (!_isUpdatingCheckBoxes && ((CheckBox)sender).Checked && !cbTransactionsSection.Checked)
            {
                cbTransactionsSection.Checked = true;
            }
        }

    }
}
                                                                                                                                                                                                                                                          