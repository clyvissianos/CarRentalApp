namespace CarRentalApp
{
    partial class AddEditVehicle
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLicenseNumber = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbVin = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(107, 337);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(153, 62);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(418, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 60);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTitle.Location = new System.Drawing.Point(146, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 63);
            this.lblTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "VIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "License Plate Number";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.16129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.83871F));
            this.tableLayoutPanel1.Controls.Add(this.tbLicenseNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbVin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMake, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(107, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbLicenseNumber
            // 
            this.tbLicenseNumber.Location = new System.Drawing.Point(175, 191);
            this.tbLicenseNumber.Name = "tbLicenseNumber";
            this.tbLicenseNumber.Size = new System.Drawing.Size(206, 20);
            this.tbLicenseNumber.TabIndex = 13;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(175, 144);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(206, 20);
            this.tbYear.TabIndex = 12;
            // 
            // tbVin
            // 
            this.tbVin.Location = new System.Drawing.Point(175, 97);
            this.tbVin.Name = "tbVin";
            this.tbVin.Size = new System.Drawing.Size(206, 20);
            this.tbVin.TabIndex = 11;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(175, 50);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(206, 20);
            this.tbModel.TabIndex = 10;
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(175, 3);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(206, 20);
            this.tbMake.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.Text = "Add / Edit Vehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbLicenseNumber;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbVin;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Label lblId;
    }
}