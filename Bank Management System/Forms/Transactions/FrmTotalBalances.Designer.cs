namespace Bank_Management_System.Forms.Transactions
{
    partial class FrmTotalBalances
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
            this.dgvTotalBalances = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotalBalances
            // 
            this.dgvTotalBalances.AllowUserToAddRows = false;
            this.dgvTotalBalances.AllowUserToDeleteRows = false;
            this.dgvTotalBalances.AllowUserToOrderColumns = true;
            this.dgvTotalBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalBalances.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTotalBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalBalances.GridColor = System.Drawing.Color.LightGray;
            this.dgvTotalBalances.Location = new System.Drawing.Point(3, 12);
            this.dgvTotalBalances.Name = "dgvTotalBalances";
            this.dgvTotalBalances.ReadOnly = true;
            this.dgvTotalBalances.RowHeadersWidth = 62;
            this.dgvTotalBalances.RowTemplate.Height = 28;
            this.dgvTotalBalances.Size = new System.Drawing.Size(760, 315);
            this.dgvTotalBalances.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(24, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmTotalBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvTotalBalances);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmTotalBalances";
            this.Text = "FrmTotalBalances";
            this.Load += new System.EventHandler(this.FrmTotalBalances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotalBalances;
        private System.Windows.Forms.Button btnBack;
    }
}