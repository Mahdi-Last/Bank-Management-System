namespace Bank_Management_System.Forms.Users
{
    partial class FrmUsers
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnClinetsList = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lbl.Location = new System.Drawing.Point(59, 5);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(651, 40);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Access Denied. \r\nYou do not have the required permissions to perform actions on t" +
    "he Users page.";
            this.lbl.Visible = false;
            // 
            // btnClinetsList
            // 
            this.btnClinetsList.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClinetsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinetsList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinetsList.ForeColor = System.Drawing.Color.White;
            this.btnClinetsList.Image = global::Bank_Management_System.Properties.Resources.icons8_persons_64;
            this.btnClinetsList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClinetsList.Location = new System.Drawing.Point(6, 65);
            this.btnClinetsList.Name = "btnClinetsList";
            this.btnClinetsList.Padding = new System.Windows.Forms.Padding(12, 5, 7, 0);
            this.btnClinetsList.Size = new System.Drawing.Size(145, 356);
            this.btnClinetsList.TabIndex = 2;
            this.btnClinetsList.Text = " Users List";
            this.btnClinetsList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClinetsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClinetsList.UseVisualStyleBackColor = false;
            this.btnClinetsList.Click += new System.EventHandler(this.btnClinetsList_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Image = global::Bank_Management_System.Properties.Resources.icons8_update_50;
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateUser.Location = new System.Drawing.Point(613, 65);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(12, 5, 7, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(145, 356);
            this.btnUpdateUser.TabIndex = 4;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = global::Bank_Management_System.Properties.Resources.icons8_delete_641;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteUser.Location = new System.Drawing.Point(462, 66);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(12, 0, 5, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(145, 356);
            this.btnDeleteUser.TabIndex = 5;
            this.btnDeleteUser.Text = " Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.Image = global::Bank_Management_System.Properties.Resources.icons8_find_64;
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFindUser.Location = new System.Drawing.Point(159, 66);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Padding = new System.Windows.Forms.Padding(12, 5, 7, 0);
            this.btnFindUser.Size = new System.Drawing.Size(145, 356);
            this.btnFindUser.TabIndex = 3;
            this.btnFindUser.Text = "   Find User";
            this.btnFindUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFindUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFindUser.UseVisualStyleBackColor = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::Bank_Management_System.Properties.Resources.icons8_add_male_user_641;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddUser.Location = new System.Drawing.Point(311, 65);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(12, 1, 7, 0);
            this.btnAddUser.Size = new System.Drawing.Size(145, 356);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = " Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.btnClinetsList);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnFindUser);
            this.Controls.Add(this.btnAddUser);
            this.Name = "FrmUsers";
            this.Text = "FrmUsers";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnClinetsList;
    }
}