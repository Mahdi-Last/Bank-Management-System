namespace Bank_Management_System.Forms.Transactions
{
    partial class FrmTransfer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBalanceFrom = new System.Windows.Forms.TextBox();
            this.txtPhoneFrom = new System.Windows.Forms.TextBox();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.txtFirstNameFrom = new System.Windows.Forms.TextBox();
            this.txtLastNameFrom = new System.Windows.Forms.TextBox();
            this.txtToAccountNumber = new System.Windows.Forms.TextBox();
            this.txtLastNameTo = new System.Windows.Forms.TextBox();
            this.txtFirstNameTo = new System.Windows.Forms.TextBox();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.txtPhoneTo = new System.Windows.Forms.TextBox();
            this.txtBalanceTo = new System.Windows.Forms.TextBox();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.btnSearchAndSend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 54);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(529, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transfer To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transfer From";
            // 
            // txtFromAccountNumber
            // 
            this.txtFromAccountNumber.CausesValidation = false;
            this.txtFromAccountNumber.Location = new System.Drawing.Point(9, 87);
            this.txtFromAccountNumber.Multiline = true;
            this.txtFromAccountNumber.Name = "txtFromAccountNumber";
            this.txtFromAccountNumber.Size = new System.Drawing.Size(324, 35);
            this.txtFromAccountNumber.TabIndex = 1;
            // 
            // txtBalanceFrom
            // 
            this.txtBalanceFrom.Enabled = false;
            this.txtBalanceFrom.Location = new System.Drawing.Point(170, 268);
            this.txtBalanceFrom.Multiline = true;
            this.txtBalanceFrom.Name = "txtBalanceFrom";
            this.txtBalanceFrom.Size = new System.Drawing.Size(159, 35);
            this.txtBalanceFrom.TabIndex = 2;
            // 
            // txtPhoneFrom
            // 
            this.txtPhoneFrom.Enabled = false;
            this.txtPhoneFrom.Location = new System.Drawing.Point(9, 268);
            this.txtPhoneFrom.Multiline = true;
            this.txtPhoneFrom.Name = "txtPhoneFrom";
            this.txtPhoneFrom.Size = new System.Drawing.Size(159, 35);
            this.txtPhoneFrom.TabIndex = 3;
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Enabled = false;
            this.txtEmailFrom.Location = new System.Drawing.Point(9, 206);
            this.txtEmailFrom.Multiline = true;
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(324, 35);
            this.txtEmailFrom.TabIndex = 4;
            // 
            // txtFirstNameFrom
            // 
            this.txtFirstNameFrom.Enabled = false;
            this.txtFirstNameFrom.Location = new System.Drawing.Point(9, 153);
            this.txtFirstNameFrom.Multiline = true;
            this.txtFirstNameFrom.Name = "txtFirstNameFrom";
            this.txtFirstNameFrom.Size = new System.Drawing.Size(159, 35);
            this.txtFirstNameFrom.TabIndex = 5;
            // 
            // txtLastNameFrom
            // 
            this.txtLastNameFrom.Enabled = false;
            this.txtLastNameFrom.Location = new System.Drawing.Point(170, 153);
            this.txtLastNameFrom.Multiline = true;
            this.txtLastNameFrom.Name = "txtLastNameFrom";
            this.txtLastNameFrom.Size = new System.Drawing.Size(159, 35);
            this.txtLastNameFrom.TabIndex = 6;
            // 
            // txtToAccountNumber
            // 
            this.txtToAccountNumber.CausesValidation = false;
            this.txtToAccountNumber.Location = new System.Drawing.Point(436, 87);
            this.txtToAccountNumber.Multiline = true;
            this.txtToAccountNumber.Name = "txtToAccountNumber";
            this.txtToAccountNumber.Size = new System.Drawing.Size(324, 35);
            this.txtToAccountNumber.TabIndex = 7;
            // 
            // txtLastNameTo
            // 
            this.txtLastNameTo.Enabled = false;
            this.txtLastNameTo.Location = new System.Drawing.Point(601, 153);
            this.txtLastNameTo.Multiline = true;
            this.txtLastNameTo.Name = "txtLastNameTo";
            this.txtLastNameTo.Size = new System.Drawing.Size(159, 35);
            this.txtLastNameTo.TabIndex = 12;
            // 
            // txtFirstNameTo
            // 
            this.txtFirstNameTo.Enabled = false;
            this.txtFirstNameTo.Location = new System.Drawing.Point(436, 153);
            this.txtFirstNameTo.Multiline = true;
            this.txtFirstNameTo.Name = "txtFirstNameTo";
            this.txtFirstNameTo.Size = new System.Drawing.Size(159, 35);
            this.txtFirstNameTo.TabIndex = 11;
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Enabled = false;
            this.txtEmailTo.Location = new System.Drawing.Point(436, 206);
            this.txtEmailTo.Multiline = true;
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(324, 35);
            this.txtEmailTo.TabIndex = 10;
            // 
            // txtPhoneTo
            // 
            this.txtPhoneTo.Enabled = false;
            this.txtPhoneTo.Location = new System.Drawing.Point(436, 268);
            this.txtPhoneTo.Multiline = true;
            this.txtPhoneTo.Name = "txtPhoneTo";
            this.txtPhoneTo.Size = new System.Drawing.Size(159, 35);
            this.txtPhoneTo.TabIndex = 9;
            // 
            // txtBalanceTo
            // 
            this.txtBalanceTo.Enabled = false;
            this.txtBalanceTo.Location = new System.Drawing.Point(601, 268);
            this.txtBalanceTo.Multiline = true;
            this.txtBalanceTo.Name = "txtBalanceTo";
            this.txtBalanceTo.Size = new System.Drawing.Size(159, 35);
            this.txtBalanceTo.TabIndex = 8;
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Enabled = false;
            this.txtTransferAmount.Location = new System.Drawing.Point(227, 335);
            this.txtTransferAmount.Multiline = true;
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(324, 35);
            this.txtTransferAmount.TabIndex = 13;
            // 
            // btnSearchAndSend
            // 
            this.btnSearchAndSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearchAndSend.FlatAppearance.BorderSize = 0;
            this.btnSearchAndSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAndSend.ForeColor = System.Drawing.Color.White;
            this.btnSearchAndSend.Location = new System.Drawing.Point(650, 387);
            this.btnSearchAndSend.Name = "btnSearchAndSend";
            this.btnSearchAndSend.Size = new System.Drawing.Size(110, 45);
            this.btnSearchAndSend.TabIndex = 14;
            this.btnSearchAndSend.Text = "Search";
            this.btnSearchAndSend.UseVisualStyleBackColor = false;
            this.btnSearchAndSend.Click += new System.EventHandler(this.btnSearchAndSend_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 45);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnClear.Location = new System.Drawing.Point(503, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 45);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchAndSend);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.txtLastNameTo);
            this.Controls.Add(this.txtFirstNameTo);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.txtPhoneTo);
            this.Controls.Add(this.txtBalanceTo);
            this.Controls.Add(this.txtToAccountNumber);
            this.Controls.Add(this.txtLastNameFrom);
            this.Controls.Add(this.txtFirstNameFrom);
            this.Controls.Add(this.txtEmailFrom);
            this.Controls.Add(this.txtPhoneFrom);
            this.Controls.Add(this.txtBalanceFrom);
            this.Controls.Add(this.txtFromAccountNumber);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTransfer";
            this.Text = "FrmTransfer";
            this.Load += new System.EventHandler(this.FrmTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromAccountNumber;
        private System.Windows.Forms.TextBox txtBalanceFrom;
        private System.Windows.Forms.TextBox txtPhoneFrom;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.TextBox txtFirstNameFrom;
        private System.Windows.Forms.TextBox txtLastNameFrom;
        private System.Windows.Forms.TextBox txtToAccountNumber;
        private System.Windows.Forms.TextBox txtLastNameTo;
        private System.Windows.Forms.TextBox txtFirstNameTo;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.TextBox txtPhoneTo;
        private System.Windows.Forms.TextBox txtBalanceTo;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Button btnSearchAndSend;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}