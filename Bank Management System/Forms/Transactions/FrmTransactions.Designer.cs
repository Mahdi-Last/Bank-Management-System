namespace Bank_Management_System.Forms.Transactions
{
    partial class FrmTransactions
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransferLog = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTotalBalances = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = global::Bank_Management_System.Properties.Resources.icons8_deposit_64;
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeposit.Location = new System.Drawing.Point(6, 65);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(12, 5, 7, 0);
            this.btnDeposit.Size = new System.Drawing.Size(145, 356);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTransferLog.FlatAppearance.BorderSize = 0;
            this.btnTransferLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferLog.ForeColor = System.Drawing.Color.White;
            this.btnTransferLog.Image = global::Bank_Management_System.Properties.Resources.icons8_history_64;
            this.btnTransferLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransferLog.Location = new System.Drawing.Point(614, 65);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.Padding = new System.Windows.Forms.Padding(12, 5, 7, 0);
            this.btnTransferLog.Size = new System.Drawing.Size(145, 356);
            this.btnTransferLog.TabIndex = 4;
            this.btnTransferLog.Text = "Transfer Log";
            this.btnTransferLog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransferLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransferLog.UseVisualStyleBackColor = false;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransferLog_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = global::Bank_Management_System.Properties.Resources.icons8_transfer_64;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransfer.Location = new System.Drawing.Point(463, 66);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(12, 0, 5, 0);
            this.btnTransfer.Size = new System.Drawing.Size(145, 356);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Image = global::Bank_Management_System.Properties.Resources.icons8_withdraw_64;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWithdraw.Location = new System.Drawing.Point(158, 66);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(12, 5, 7, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(145, 356);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTotalBalances.FlatAppearance.BorderSize = 0;
            this.btnTotalBalances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalBalances.ForeColor = System.Drawing.Color.White;
            this.btnTotalBalances.Image = global::Bank_Management_System.Properties.Resources.icons8_money_64;
            this.btnTotalBalances.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTotalBalances.Location = new System.Drawing.Point(311, 65);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.Padding = new System.Windows.Forms.Padding(12, 1, 7, 0);
            this.btnTotalBalances.Size = new System.Drawing.Size(145, 356);
            this.btnTotalBalances.TabIndex = 6;
            this.btnTotalBalances.Text = "Total Balances";
            this.btnTotalBalances.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTotalBalances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTotalBalances.UseVisualStyleBackColor = false;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lbl.Location = new System.Drawing.Point(37, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(707, 40);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Access Denied. \r\nYou do not have the required permissions to perform actions on t" +
    "he Transactions page.";
            this.lbl.Visible = false;
            // 
            // FrmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnTransferLog);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnTotalBalances);
            this.Name = "FrmTransactions";
            this.Text = "FrmTransactions";
            this.Load += new System.EventHandler(this.FrmTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransferLog;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTotalBalances;
        private System.Windows.Forms.Label lbl;
    }
}