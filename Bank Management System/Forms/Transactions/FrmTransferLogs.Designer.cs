namespace Bank_Management_System.Forms.Transactions
{
    partial class FrmTransferLogs
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
            this.dgvAllTransferLogs = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransferLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTransferLogs
            // 
            this.dgvAllTransferLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTransferLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAllTransferLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTransferLogs.Location = new System.Drawing.Point(3, 12);
            this.dgvAllTransferLogs.Name = "dgvAllTransferLogs";
            this.dgvAllTransferLogs.RowHeadersWidth = 62;
            this.dgvAllTransferLogs.RowTemplate.Height = 28;
            this.dgvAllTransferLogs.Size = new System.Drawing.Size(760, 315);
            this.dgvAllTransferLogs.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmTransferLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAllTransferLogs);
            this.Name = "FrmTransferLogs";
            this.Text = "FrmTransferLog";
            this.Load += new System.EventHandler(this.FrmTransferLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransferLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTransferLogs;
        private System.Windows.Forms.Button btnBack;
    }
}