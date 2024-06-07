namespace CarRentalApp
{
    partial class ManageUsers
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
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUsersList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(585, 366);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(87, 33);
            this.btnRefreshGrid.TabIndex = 17;
            this.btnRefreshGrid.Text = "Refresh";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Location = new System.Drawing.Point(259, 366);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(144, 33);
            this.btnDeactivateUser.TabIndex = 16;
            this.btnDeactivateUser.Text = "Deactivate/Activate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(139, 366);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(95, 33);
            this.btnResetPassword.TabIndex = 15;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(12, 366);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(97, 33);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 63);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            // 
            // gvUsersList
            // 
            this.gvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsersList.Location = new System.Drawing.Point(12, 75);
            this.gvUsersList.Name = "gvUsersList";
            this.gvUsersList.Size = new System.Drawing.Size(660, 270);
            this.gvUsersList.TabIndex = 12;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnRefreshGrid);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvUsersList);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUsersList;
    }
}