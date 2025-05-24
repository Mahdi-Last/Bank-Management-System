namespace Bank_Management_System.Forms.Users
{
    partial class FrmDeleteUser
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPermissions = new System.Windows.Forms.TextBox();
            this.lblPermission = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSearchAndDelete = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 65;
            this.lblEmail.Text = "Email";
            // 
            // txtPermissions
            // 
            this.txtPermissions.Enabled = false;
            this.txtPermissions.Location = new System.Drawing.Point(548, 300);
            this.txtPermissions.Multiline = true;
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.Size = new System.Drawing.Size(178, 34);
            this.txtPermissions.TabIndex = 64;
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermission.Location = new System.Drawing.Point(413, 306);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(118, 25);
            this.lblPermission.TabIndex = 63;
            this.lblPermission.Text = "Permissions";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(548, 96);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 34);
            this.txtLastName.TabIndex = 62;
            // 
            // btnSearchAndDelete
            // 
            this.btnSearchAndDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearchAndDelete.FlatAppearance.BorderSize = 0;
            this.btnSearchAndDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAndDelete.ForeColor = System.Drawing.Color.White;
            this.btnSearchAndDelete.Location = new System.Drawing.Point(616, 371);
            this.btnSearchAndDelete.Name = "btnSearchAndDelete";
            this.btnSearchAndDelete.Size = new System.Drawing.Size(110, 45);
            this.btnSearchAndDelete.TabIndex = 61;
            this.btnSearchAndDelete.Text = "Search";
            this.btnSearchAndDelete.UseVisualStyleBackColor = false;
            this.btnSearchAndDelete.Click += new System.EventHandler(this.btnSearchAndDelete_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(50, 300);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(98, 25);
            this.lblBalance.TabIndex = 60;
            this.lblBalance.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(161, 300);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 34);
            this.txtPassword.TabIndex = 59;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(50, 232);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 58;
            this.lblPhone.Text = "Phone";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(413, 96);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 25);
            this.lblLastName.TabIndex = 57;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(50, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirstName.TabIndex = 56;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(50, 22);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(102, 25);
            this.lblAccountNumber.TabIndex = 55;
            this.lblAccountNumber.Text = "Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(161, 166);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 36);
            this.txtEmail.TabIndex = 54;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(161, 90);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 34);
            this.txtFirstName.TabIndex = 53;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(161, 232);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(334, 35);
            this.txtPhone.TabIndex = 52;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(161, 22);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(236, 33);
            this.txtUsername.TabIndex = 51;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(55, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 45);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(440, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 45);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPermissions);
            this.Controls.Add(this.lblPermission);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnSearchAndDelete);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Name = "FrmDeleteUser";
            this.Text = "FrmDeleteUser";
            this.Load += new System.EventHandler(this.FrmDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearchAndDelete;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}