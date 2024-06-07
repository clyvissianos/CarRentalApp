namespace CarRentalApp
{
    partial class AddEditRentalRecord
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTitle.Location = new System.Drawing.Point(52, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 63);
            this.lblTitle.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(21, 128);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(217, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(22, 191);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(216, 20);
            this.dtRented.TabIndex = 3;
            // 
            // dtReturned
            // 
            this.dtReturned.Location = new System.Drawing.Point(277, 191);
            this.dtReturned.Name = "dtReturned";
            this.dtReturned.Size = new System.Drawing.Size(216, 20);
            this.dtReturned.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(21, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Rented";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(273, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Returned";
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(22, 254);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(216, 21);
            this.cbTypeOfCar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(21, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type Of Car";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Submit.Location = new System.Drawing.Point(349, 264);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(144, 48);
            this.Submit.TabIndex = 9;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(277, 127);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(216, 20);
            this.txtCost.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(274, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost";
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(21, 89);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 13);
            this.lblRecordId.TabIndex = 12;
            this.lblRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 341);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtReturned);
            this.Controls.Add(this.dtRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRecordId;
    }
}

