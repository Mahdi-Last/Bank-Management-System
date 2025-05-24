namespace Bank_Management_System.Forms.Users
{
    partial class FrmUpdateUser
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
            this.btnPermission = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearchAndUpdate = new System.Windows.Forms.Button();
            this.txtPermissions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPermission
            // 
            this.btnPermission.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPermission.Enabled = false;
            this.btnPermission.FlatAppearance.BorderSize = 0;
            this.btnPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermission.ForeColor = System.Drawing.Color.White;
            this.btnPermission.Location = new System.Drawing.Point(634, 209);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(110, 45);
            this.btnPermission.TabIndex = 48;
            this.btnPermission.Text = "Permissions";
            this.btnPermission.UseVisualStyleBackColor = false;
            this.btnPermission.Click += new System.EventHandler(this.btnPermission_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(42, 297);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(98, 25);
            this.lblBalance.TabIndex = 47;
            this.lblBalance.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(174, 297);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 36);
            this.txtPassword.TabIndex = 46;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(42, 229);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 45;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(42, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(405, 88);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 25);
            this.lblLastName.TabIndex = 43;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(42, 86);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirstName.TabIndex = 42;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(42, 14);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(102, 25);
            this.lblAccountNumber.TabIndex = 41;
            this.lblAccountNumber.Text = "Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(174, 159);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 36);
            this.txtEmail.TabIndex = 40;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(174, 86);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 34);
            this.txtFirstName.TabIndex = 39;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(174, 219);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(334, 35);
            this.txtPhone.TabIndex = 38;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(566, 85);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 35);
            this.txtLastName.TabIndex = 37;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(174, 14);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(236, 33);
            this.txtUsername.TabIndex = 36;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(47, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 45);
            this.btnBack.TabIndex = 35;
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
            this.btnClear.Location = new System.Drawing.Point(482, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 45);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearchAndUpdate
            // 
            this.btnSearchAndUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearchAndUpdate.FlatAppearance.BorderSize = 0;
            this.btnSearchAndUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAndUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSearchAndUpdate.Location = new System.Drawing.Point(634, 371);
            this.btnSearchAndUpdate.Name = "btnSearchAndUpdate";
            this.btnSearchAndUpdate.Size = new System.Drawing.Size(110, 45);
            this.btnSearchAndUpdate.TabIndex = 33;
            this.btnSearchAndUpdate.Text = "Search";
            this.btnSearchAndUpdate.UseVisualStyleBackColor = false;
            this.btnSearchAndUpdate.Click += new System.EventHandler(this.btnSearchAndUpdate_Click);
            // 
            // txtPermissions
            // 
            this.txtPermissions.Enabled = false;
            this.txtPermissions.Location = new System.Drawing.Point(559, 298);
            this.txtPermissions.Multiline = true;
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.Size = new System.Drawing.Size(185, 36);
            this.txtPermissions.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Permissions";
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPermissions);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearchAndUpdate);
            this.Name = "FrmUpdateUser";
            this.Text = "FrmUpdateUser";
            this.Load += new System.EventHandler(this.FrmUpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPermission;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearchAndUpdate;
        private System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.Label label1;
    }
}