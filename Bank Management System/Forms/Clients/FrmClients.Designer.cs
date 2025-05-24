namespace Bank_Management_System.Clients
{
    partial class FrmClients
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
            this.btnClinetsList = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClinetsList
            // 
            this.btnClinetsList.BackColor = System.Drawing.Color.Teal;
            this.btnClinetsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinetsList.ForeColor = System.Drawing.Color.White;
            this.btnClinetsList.Image = global::Bank_Management_System.Properties.Resources.icons8_list_641;
            this.btnClinetsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinetsList.Location = new System.Drawing.Point(6, 116);
            this.btnClinetsList.Name = "btnClinetsList";
            this.btnClinetsList.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnClinetsList.Size = new System.Drawing.Size(754, 85);
            this.btnClinetsList.TabIndex = 2;
            this.btnClinetsList.Text = "   Clients List";
            this.btnClinetsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClinetsList.UseVisualStyleBackColor = false;
            this.btnClinetsList.Click += new System.EventHandler(this.btnClinetsList_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.Image = global::Bank_Management_System.Properties.Resources.icons8_update_50;
            this.btnUpdateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClient.Location = new System.Drawing.Point(6, 210);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnUpdateClient.Size = new System.Drawing.Size(267, 83);
            this.btnUpdateClient.TabIndex = 4;
            this.btnUpdateClient.Text = "     Update Client";
            this.btnUpdateClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Image = global::Bank_Management_System.Properties.Resources.icons8_delete_641;
            this.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.Location = new System.Drawing.Point(6, 301);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnDeleteClient.Size = new System.Drawing.Size(754, 85);
            this.btnDeleteClient.TabIndex = 5;
            this.btnDeleteClient.Text = "   Delete Client";
            this.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.Color.Teal;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.ForeColor = System.Drawing.Color.White;
            this.btnFindClient.Image = global::Bank_Management_System.Properties.Resources.icons8_find_64;
            this.btnFindClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.Location = new System.Drawing.Point(576, 210);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFindClient.Size = new System.Drawing.Size(184, 85);
            this.btnFindClient.TabIndex = 3;
            this.btnFindClient.Text = "   Find Client";
            this.btnFindClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindClient.UseVisualStyleBackColor = false;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Teal;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Image = global::Bank_Management_System.Properties.Resources.icons8_add_male_user_641;
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.Location = new System.Drawing.Point(279, 210);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddClient.Size = new System.Drawing.Size(291, 85);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "   Add Client";
            this.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lbl.Location = new System.Drawing.Point(50, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(659, 40);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Access Denied. \r\nYou do not have the required permissions to perform actions on t" +
    "he Clients page.";
            this.lbl.Visible = false;
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.btnClinetsList);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.btnAddClient);
            this.Name = "FrmClients";
            this.Text = "FrmClinets";
            this.Load += new System.EventHandler(this.FrmClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClinetsList;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label lbl;
    }
}