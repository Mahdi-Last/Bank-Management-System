namespace Bank_Management_System.Forms.Transactions
{
    partial class FrmWithdraw
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
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearchAndSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(241, 315);
            this.txtWithdrawAmount.Multiline = true;
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(191, 36);
            this.txtWithdrawAmount.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblAccountNumber);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Location = new System.Drawing.Point(42, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 50);
            this.panel1.TabIndex = 86;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.White;
            this.lblAccountNumber.Location = new System.Drawing.Point(18, 12);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(153, 25);
            this.lblAccountNumber.TabIndex = 59;
            this.lblAccountNumber.Text = "AccountNumber";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(498, 8);
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(178, 33);
            this.txtAccountNumber.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Withdraw Amount";
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.Location = new System.Drawing.Point(421, 265);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(88, 25);
            this.lblPinCode.TabIndex = 85;
            this.lblPinCode.Text = "PinCode";
            // 
            // txtPinCode
            // 
            this.txtPinCode.Enabled = false;
            this.txtPinCode.Location = new System.Drawing.Point(540, 260);
            this.txtPinCode.Multiline = true;
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(178, 36);
            this.txtPinCode.TabIndex = 84;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(60, 254);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(83, 25);
            this.lblBalance.TabIndex = 83;
            this.lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(192, 254);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(185, 36);
            this.txtBalance.TabIndex = 82;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(60, 199);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 81;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(60, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 80;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(408, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 25);
            this.lblLastName.TabIndex = 79;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(60, 81);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirstName.TabIndex = 78;
            this.lblFirstName.Text = "FirstName";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(192, 143);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 36);
            this.txtEmail.TabIndex = 77;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(192, 81);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 34);
            this.txtFirstName.TabIndex = 76;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(192, 199);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(334, 35);
            this.txtPhone.TabIndex = 75;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(540, 80);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 35);
            this.txtLastName.TabIndex = 74;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(42, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 45);
            this.btnBack.TabIndex = 73;
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
            this.btnClear.Location = new System.Drawing.Point(477, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 45);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearchAndSend
            // 
            this.btnSearchAndSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearchAndSend.FlatAppearance.BorderSize = 0;
            this.btnSearchAndSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAndSend.ForeColor = System.Drawing.Color.White;
            this.btnSearchAndSend.Location = new System.Drawing.Point(634, 387);
            this.btnSearchAndSend.Name = "btnSearchAndSend";
            this.btnSearchAndSend.Size = new System.Drawing.Size(110, 45);
            this.btnSearchAndSend.TabIndex = 71;
            this.btnSearchAndSend.Text = "Search";
            this.btnSearchAndSend.UseVisualStyleBackColor = false;
            this.btnSearchAndSend.Click += new System.EventHandler(this.btnSearchAndSend_Click);
            // 
            // FrmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearchAndSend);
            this.Name = "FrmWithdraw";
            this.Text = "FrmWithdraw";
            this.Load += new System.EventHandler(this.FrmWithdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearchAndSend;
    }
}