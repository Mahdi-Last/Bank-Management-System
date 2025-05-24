namespace Bank_Management_System
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.plMyPanel = new System.Windows.Forms.Panel();
            this.linklbl = new System.Windows.Forms.LinkLabel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLoginRegisters = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.plMainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plMyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.plMainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMyPanel
            // 
            this.plMyPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.plMyPanel.Controls.Add(this.linklbl);
            this.plMyPanel.Controls.Add(this.btnHome);
            this.plMyPanel.Controls.Add(this.panel1);
            this.plMyPanel.Controls.Add(this.btnLogout);
            this.plMyPanel.Controls.Add(this.btnLoginRegisters);
            this.plMyPanel.Controls.Add(this.btnTransactions);
            this.plMyPanel.Controls.Add(this.btnUsers);
            this.plMyPanel.Controls.Add(this.btnClients);
            this.plMyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMyPanel.Location = new System.Drawing.Point(0, 0);
            this.plMyPanel.Name = "plMyPanel";
            this.plMyPanel.Size = new System.Drawing.Size(226, 544);
            this.plMyPanel.TabIndex = 0;
            this.plMyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.plMyPanel_Paint);
            // 
            // linklbl
            // 
            this.linklbl.AutoSize = true;
            this.linklbl.LinkColor = System.Drawing.Color.Transparent;
            this.linklbl.Location = new System.Drawing.Point(52, 515);
            this.linklbl.Name = "linklbl";
            this.linklbl.Size = new System.Drawing.Size(107, 20);
            this.linklbl.TabIndex = 1;
            this.linklbl.TabStop = true;
            this.linklbl.Text = "Developed By";
            this.linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1, 80);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(22, 0, 9, 0);
            this.btnHome.Size = new System.Drawing.Size(226, 66);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 92);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MBANK";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-1, 433);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(226, 65);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLoginRegisters
            // 
            this.btnLoginRegisters.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoginRegisters.FlatAppearance.BorderSize = 0;
            this.btnLoginRegisters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRegisters.ForeColor = System.Drawing.Color.White;
            this.btnLoginRegisters.Image = global::Bank_Management_System.Properties.Resources.icons8_activity_history_50;
            this.btnLoginRegisters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginRegisters.Location = new System.Drawing.Point(-1, 361);
            this.btnLoginRegisters.Name = "btnLoginRegisters";
            this.btnLoginRegisters.Padding = new System.Windows.Forms.Padding(25, 0, 9, 0);
            this.btnLoginRegisters.Size = new System.Drawing.Size(226, 66);
            this.btnLoginRegisters.TabIndex = 4;
            this.btnLoginRegisters.Text = "   LoginRegisters";
            this.btnLoginRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginRegisters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginRegisters.UseVisualStyleBackColor = false;
            this.btnLoginRegisters.Click += new System.EventHandler(this.btnLoginRegisters_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = global::Bank_Management_System.Properties.Resources.icons8_transactions_50;
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(-1, 289);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(24, 0, 9, 0);
            this.btnTransactions.Size = new System.Drawing.Size(226, 66);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "   Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Bank_Management_System.Properties.Resources.icons8_user_settings_50;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(-1, 217);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(23, 0, 9, 0);
            this.btnUsers.Size = new System.Drawing.Size(226, 66);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "   Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 152);
            this.btnClients.Name = "btnClients";
            this.btnClients.Padding = new System.Windows.Forms.Padding(26, 0, 9, 0);
            this.btnClients.Size = new System.Drawing.Size(226, 66);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "   Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click_1);
            // 
            // plMainPanel
            // 
            this.plMainPanel.Controls.Add(this.label2);
            this.plMainPanel.Location = new System.Drawing.Point(226, 81);
            this.plMainPanel.Name = "plMainPanel";
            this.plMainPanel.Size = new System.Drawing.Size(766, 463);
            this.plMainPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(17, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(737, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Access Denied. Please contact your administrator to access your home page.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(235, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 53);
            this.panel2.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(484, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(24, 28);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(408, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(198, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(24, 28);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome Back: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plMainPanel);
            this.Controls.Add(this.plMyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Managment System";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.plMyPanel.ResumeLayout(false);
            this.plMyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plMainPanel.ResumeLayout(false);
            this.plMainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMyPanel;
        private System.Windows.Forms.Button btnLoginRegisters;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel plMainPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linklbl;
    }
}