namespace Bank_Management_System.Forms.Users
{
    partial class FrmPermissions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbUsersSection = new System.Windows.Forms.CheckBox();
            this.cbClientsSection = new System.Windows.Forms.CheckBox();
            this.cbTransactionsSection = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTotalBalances = new System.Windows.Forms.CheckBox();
            this.cbTransfer = new System.Windows.Forms.CheckBox();
            this.cbTransferLog = new System.Windows.Forms.CheckBox();
            this.cbWithdraw = new System.Windows.Forms.CheckBox();
            this.cbDeposit = new System.Windows.Forms.CheckBox();
            this.cbAddUser = new System.Windows.Forms.CheckBox();
            this.cbUpdateUser = new System.Windows.Forms.CheckBox();
            this.cbDeleteUser = new System.Windows.Forms.CheckBox();
            this.cbFindUser = new System.Windows.Forms.CheckBox();
            this.cbUsersList = new System.Windows.Forms.CheckBox();
            this.cbAddClient = new System.Windows.Forms.CheckBox();
            this.cbUpdateClient = new System.Windows.Forms.CheckBox();
            this.cbDeleteClient = new System.Windows.Forms.CheckBox();
            this.cbFindClient = new System.Windows.Forms.CheckBox();
            this.cbClientsList = new System.Windows.Forms.CheckBox();
            this.cbFullAccess = new System.Windows.Forms.CheckBox();
            this.cbLoginRegisters = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbHome = new System.Windows.Forms.CheckBox();
            this.btnUnCheckedAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUsersSection
            // 
            this.cbUsersSection.AutoSize = true;
            this.cbUsersSection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbUsersSection.Location = new System.Drawing.Point(228, 3);
            this.cbUsersSection.Name = "cbUsersSection";
            this.cbUsersSection.Size = new System.Drawing.Size(135, 24);
            this.cbUsersSection.TabIndex = 0;
            this.cbUsersSection.Text = "Users Section";
            this.cbUsersSection.UseVisualStyleBackColor = true;
            this.cbUsersSection.CheckedChanged += new System.EventHandler(this.cbUsersSection_CheckedChanged);
            // 
            // cbClientsSection
            // 
            this.cbClientsSection.AutoSize = true;
            this.cbClientsSection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbClientsSection.Location = new System.Drawing.Point(21, 3);
            this.cbClientsSection.Name = "cbClientsSection";
            this.cbClientsSection.Size = new System.Drawing.Size(141, 24);
            this.cbClientsSection.TabIndex = 1;
            this.cbClientsSection.Text = "Clients Section";
            this.cbClientsSection.UseVisualStyleBackColor = true;
            this.cbClientsSection.CheckedChanged += new System.EventHandler(this.cbClientsSection_CheckedChanged);
            // 
            // cbTransactionsSection
            // 
            this.cbTransactionsSection.AutoSize = true;
            this.cbTransactionsSection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbTransactionsSection.Location = new System.Drawing.Point(448, 3);
            this.cbTransactionsSection.Name = "cbTransactionsSection";
            this.cbTransactionsSection.Size = new System.Drawing.Size(176, 24);
            this.cbTransactionsSection.TabIndex = 2;
            this.cbTransactionsSection.Text = "Transaction Section";
            this.cbTransactionsSection.UseVisualStyleBackColor = true;
            this.cbTransactionsSection.CheckedChanged += new System.EventHandler(this.cbTransactionsSection_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.cbTotalBalances);
            this.panel1.Controls.Add(this.cbTransfer);
            this.panel1.Controls.Add(this.cbTransferLog);
            this.panel1.Controls.Add(this.cbWithdraw);
            this.panel1.Controls.Add(this.cbDeposit);
            this.panel1.Controls.Add(this.cbAddUser);
            this.panel1.Controls.Add(this.cbUpdateUser);
            this.panel1.Controls.Add(this.cbDeleteUser);
            this.panel1.Controls.Add(this.cbFindUser);
            this.panel1.Controls.Add(this.cbUsersList);
            this.panel1.Controls.Add(this.cbAddClient);
            this.panel1.Controls.Add(this.cbUpdateClient);
            this.panel1.Controls.Add(this.cbDeleteClient);
            this.panel1.Controls.Add(this.cbFindClient);
            this.panel1.Controls.Add(this.cbClientsList);
            this.panel1.Controls.Add(this.cbTransactionsSection);
            this.panel1.Controls.Add(this.cbUsersSection);
            this.panel1.Controls.Add(this.cbClientsSection);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 230);
            this.panel1.TabIndex = 3;
            // 
            // cbTotalBalances
            // 
            this.cbTotalBalances.AutoSize = true;
            this.cbTotalBalances.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbTotalBalances.Location = new System.Drawing.Point(471, 103);
            this.cbTotalBalances.Name = "cbTotalBalances";
            this.cbTotalBalances.Size = new System.Drawing.Size(140, 24);
            this.cbTotalBalances.TabIndex = 17;
            this.cbTotalBalances.Text = "Total Balances";
            this.cbTotalBalances.UseVisualStyleBackColor = true;
            // 
            // cbTransfer
            // 
            this.cbTransfer.AutoSize = true;
            this.cbTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbTransfer.Location = new System.Drawing.Point(471, 133);
            this.cbTransfer.Name = "cbTransfer";
            this.cbTransfer.Size = new System.Drawing.Size(94, 24);
            this.cbTransfer.TabIndex = 16;
            this.cbTransfer.Text = "Transfer";
            this.cbTransfer.UseVisualStyleBackColor = true;
            // 
            // cbTransferLog
            // 
            this.cbTransferLog.AutoSize = true;
            this.cbTransferLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbTransferLog.Location = new System.Drawing.Point(471, 163);
            this.cbTransferLog.Name = "cbTransferLog";
            this.cbTransferLog.Size = new System.Drawing.Size(125, 24);
            this.cbTransferLog.TabIndex = 15;
            this.cbTransferLog.Text = "Transfer Log";
            this.cbTransferLog.UseVisualStyleBackColor = true;
            // 
            // cbWithdraw
            // 
            this.cbWithdraw.AutoSize = true;
            this.cbWithdraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbWithdraw.Location = new System.Drawing.Point(471, 73);
            this.cbWithdraw.Name = "cbWithdraw";
            this.cbWithdraw.Size = new System.Drawing.Size(101, 24);
            this.cbWithdraw.TabIndex = 14;
            this.cbWithdraw.Text = "Withdraw";
            this.cbWithdraw.UseVisualStyleBackColor = true;
            // 
            // cbDeposit
            // 
            this.cbDeposit.AutoSize = true;
            this.cbDeposit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbDeposit.Location = new System.Drawing.Point(471, 43);
            this.cbDeposit.Name = "cbDeposit";
            this.cbDeposit.Size = new System.Drawing.Size(90, 24);
            this.cbDeposit.TabIndex = 13;
            this.cbDeposit.Text = "Deposit";
            this.cbDeposit.UseVisualStyleBackColor = true;
            // 
            // cbAddUser
            // 
            this.cbAddUser.AutoSize = true;
            this.cbAddUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbAddUser.Location = new System.Drawing.Point(248, 103);
            this.cbAddUser.Name = "cbAddUser";
            this.cbAddUser.Size = new System.Drawing.Size(102, 24);
            this.cbAddUser.TabIndex = 12;
            this.cbAddUser.Text = "Add User";
            this.cbAddUser.UseVisualStyleBackColor = true;
            // 
            // cbUpdateUser
            // 
            this.cbUpdateUser.AutoSize = true;
            this.cbUpdateUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbUpdateUser.Location = new System.Drawing.Point(248, 133);
            this.cbUpdateUser.Name = "cbUpdateUser";
            this.cbUpdateUser.Size = new System.Drawing.Size(126, 24);
            this.cbUpdateUser.TabIndex = 11;
            this.cbUpdateUser.Text = "Update User";
            this.cbUpdateUser.UseVisualStyleBackColor = true;
            // 
            // cbDeleteUser
            // 
            this.cbDeleteUser.AutoSize = true;
            this.cbDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbDeleteUser.Location = new System.Drawing.Point(248, 163);
            this.cbDeleteUser.Name = "cbDeleteUser";
            this.cbDeleteUser.Size = new System.Drawing.Size(120, 24);
            this.cbDeleteUser.TabIndex = 10;
            this.cbDeleteUser.Text = "Delete User";
            this.cbDeleteUser.UseVisualStyleBackColor = true;
            // 
            // cbFindUser
            // 
            this.cbFindUser.AutoSize = true;
            this.cbFindUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbFindUser.Location = new System.Drawing.Point(248, 73);
            this.cbFindUser.Name = "cbFindUser";
            this.cbFindUser.Size = new System.Drawing.Size(104, 24);
            this.cbFindUser.TabIndex = 9;
            this.cbFindUser.Text = "Find User";
            this.cbFindUser.UseVisualStyleBackColor = true;
            // 
            // cbUsersList
            // 
            this.cbUsersList.AutoSize = true;
            this.cbUsersList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbUsersList.Location = new System.Drawing.Point(248, 43);
            this.cbUsersList.Name = "cbUsersList";
            this.cbUsersList.Size = new System.Drawing.Size(106, 24);
            this.cbUsersList.TabIndex = 8;
            this.cbUsersList.Text = "Users List";
            this.cbUsersList.UseVisualStyleBackColor = true;
            // 
            // cbAddClient
            // 
            this.cbAddClient.AutoSize = true;
            this.cbAddClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbAddClient.Location = new System.Drawing.Point(39, 103);
            this.cbAddClient.Name = "cbAddClient";
            this.cbAddClient.Size = new System.Drawing.Size(108, 24);
            this.cbAddClient.TabIndex = 7;
            this.cbAddClient.Text = "Add Client";
            this.cbAddClient.UseVisualStyleBackColor = true;
            // 
            // cbUpdateClient
            // 
            this.cbUpdateClient.AutoSize = true;
            this.cbUpdateClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbUpdateClient.Location = new System.Drawing.Point(39, 133);
            this.cbUpdateClient.Name = "cbUpdateClient";
            this.cbUpdateClient.Size = new System.Drawing.Size(132, 24);
            this.cbUpdateClient.TabIndex = 6;
            this.cbUpdateClient.Text = "Update Client";
            this.cbUpdateClient.UseVisualStyleBackColor = true;
            // 
            // cbDeleteClient
            // 
            this.cbDeleteClient.AutoSize = true;
            this.cbDeleteClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbDeleteClient.Location = new System.Drawing.Point(39, 163);
            this.cbDeleteClient.Name = "cbDeleteClient";
            this.cbDeleteClient.Size = new System.Drawing.Size(126, 24);
            this.cbDeleteClient.TabIndex = 5;
            this.cbDeleteClient.Text = "Delete Client";
            this.cbDeleteClient.UseVisualStyleBackColor = true;
            // 
            // cbFindClient
            // 
            this.cbFindClient.AutoSize = true;
            this.cbFindClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbFindClient.Location = new System.Drawing.Point(39, 73);
            this.cbFindClient.Name = "cbFindClient";
            this.cbFindClient.Size = new System.Drawing.Size(110, 24);
            this.cbFindClient.TabIndex = 4;
            this.cbFindClient.Text = "Find Client";
            this.cbFindClient.UseVisualStyleBackColor = true;
            // 
            // cbClientsList
            // 
            this.cbClientsList.AutoSize = true;
            this.cbClientsList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbClientsList.Location = new System.Drawing.Point(39, 43);
            this.cbClientsList.Name = "cbClientsList";
            this.cbClientsList.Size = new System.Drawing.Size(112, 24);
            this.cbClientsList.TabIndex = 3;
            this.cbClientsList.Text = "Clients List";
            this.cbClientsList.UseVisualStyleBackColor = true;
            // 
            // cbFullAccess
            // 
            this.cbFullAccess.AutoSize = true;
            this.cbFullAccess.BackColor = System.Drawing.Color.LightSlateGray;
            this.cbFullAccess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbFullAccess.Location = new System.Drawing.Point(33, 21);
            this.cbFullAccess.Name = "cbFullAccess";
            this.cbFullAccess.Size = new System.Drawing.Size(116, 24);
            this.cbFullAccess.TabIndex = 3;
            this.cbFullAccess.Text = "Full Access";
            this.cbFullAccess.UseVisualStyleBackColor = false;
            this.cbFullAccess.CheckedChanged += new System.EventHandler(this.cbFullAccess_CheckedChanged);
            // 
            // cbLoginRegisters
            // 
            this.cbLoginRegisters.AutoSize = true;
            this.cbLoginRegisters.BackColor = System.Drawing.Color.LightSlateGray;
            this.cbLoginRegisters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbLoginRegisters.Location = new System.Drawing.Point(312, 21);
            this.cbLoginRegisters.Name = "cbLoginRegisters";
            this.cbLoginRegisters.Size = new System.Drawing.Size(146, 24);
            this.cbLoginRegisters.TabIndex = 4;
            this.cbLoginRegisters.Text = "Login Registers";
            this.cbLoginRegisters.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(661, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // cbHome
            // 
            this.cbHome.AutoSize = true;
            this.cbHome.BackColor = System.Drawing.Color.LightSlateGray;
            this.cbHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbHome.Location = new System.Drawing.Point(192, 21);
            this.cbHome.Name = "cbHome";
            this.cbHome.Size = new System.Drawing.Size(78, 24);
            this.cbHome.TabIndex = 7;
            this.cbHome.Text = "Home";
            this.cbHome.UseVisualStyleBackColor = false;
            // 
            // btnUnCheckedAll
            // 
            this.btnUnCheckedAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUnCheckedAll.FlatAppearance.BorderSize = 0;
            this.btnUnCheckedAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnCheckedAll.ForeColor = System.Drawing.Color.White;
            this.btnUnCheckedAll.Location = new System.Drawing.Point(542, 21);
            this.btnUnCheckedAll.Name = "btnUnCheckedAll";
            this.btnUnCheckedAll.Size = new System.Drawing.Size(131, 30);
            this.btnUnCheckedAll.TabIndex = 8;
            this.btnUnCheckedAll.Text = "UnChecked All";
            this.btnUnCheckedAll.UseVisualStyleBackColor = false;
            this.btnUnCheckedAll.Click += new System.EventHandler(this.btnUnCheckedAll_Click);
            // 
            // FrmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 358);
            this.Controls.Add(this.btnUnCheckedAll);
            this.Controls.Add(this.cbHome);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbLoginRegisters);
            this.Controls.Add(this.cbFullAccess);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermissions";
            this.Load += new System.EventHandler(this.FrmPermissions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbUsersSection;
        private System.Windows.Forms.CheckBox cbClientsSection;
        private System.Windows.Forms.CheckBox cbTransactionsSection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbFullAccess;
        private System.Windows.Forms.CheckBox cbFindClient;
        private System.Windows.Forms.CheckBox cbClientsList;
        private System.Windows.Forms.CheckBox cbAddUser;
        private System.Windows.Forms.CheckBox cbUpdateUser;
        private System.Windows.Forms.CheckBox cbDeleteUser;
        private System.Windows.Forms.CheckBox cbFindUser;
        private System.Windows.Forms.CheckBox cbUsersList;
        private System.Windows.Forms.CheckBox cbAddClient;
        private System.Windows.Forms.CheckBox cbUpdateClient;
        private System.Windows.Forms.CheckBox cbDeleteClient;
        private System.Windows.Forms.CheckBox cbTotalBalances;
        private System.Windows.Forms.CheckBox cbTransfer;
        private System.Windows.Forms.CheckBox cbTransferLog;
        private System.Windows.Forms.CheckBox cbWithdraw;
        private System.Windows.Forms.CheckBox cbDeposit;
        private System.Windows.Forms.CheckBox cbLoginRegisters;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbHome;
        private System.Windows.Forms.Button btnUnCheckedAll;
    }
}