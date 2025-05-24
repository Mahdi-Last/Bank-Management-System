namespace Bank_Management_System.Forms.LoginRegisters
{
    partial class FrmLoginRegisters
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
            this.dgvAllLoginRegisters = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLoginRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllLoginRegisters
            // 
            this.dgvAllLoginRegisters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllLoginRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllLoginRegisters.Location = new System.Drawing.Point(3, 12);
            this.dgvAllLoginRegisters.Name = "dgvAllLoginRegisters";
            this.dgvAllLoginRegisters.RowHeadersWidth = 62;
            this.dgvAllLoginRegisters.RowTemplate.Height = 28;
            this.dgvAllLoginRegisters.Size = new System.Drawing.Size(760, 345);
            this.dgvAllLoginRegisters.TabIndex = 0;
            // 
            // FrmLoginRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.dgvAllLoginRegisters);
            this.Name = "FrmLoginRegisters";
            this.Text = "FrmLoginRegisters";
            this.Load += new System.EventHandler(this.FrmLoginRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLoginRegisters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllLoginRegisters;
    }
}