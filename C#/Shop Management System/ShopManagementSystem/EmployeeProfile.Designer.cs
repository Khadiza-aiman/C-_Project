namespace ShopManagementSystem
{
    partial class EmployeeProfile
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
            this.pnlEmployeeProfile = new System.Windows.Forms.Panel();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlEmployeeProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployeeProfile
            // 
            this.pnlEmployeeProfile.AutoSize = true;
            this.pnlEmployeeProfile.BackColor = System.Drawing.Color.DimGray;
            this.pnlEmployeeProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployeeProfile.Controls.Add(this.btnBack);
            this.pnlEmployeeProfile.Controls.Add(this.btnSavePassword);
            this.pnlEmployeeProfile.Controls.Add(this.txtNewPassword);
            this.pnlEmployeeProfile.Controls.Add(this.txtOldPassword);
            this.pnlEmployeeProfile.Controls.Add(this.lblNewPassword);
            this.pnlEmployeeProfile.Controls.Add(this.lblOldPassword);
            this.pnlEmployeeProfile.Controls.Add(this.lblAdress);
            this.pnlEmployeeProfile.Controls.Add(this.lblSalary);
            this.pnlEmployeeProfile.Controls.Add(this.lblPhoneNumber);
            this.pnlEmployeeProfile.Controls.Add(this.lblEmail);
            this.pnlEmployeeProfile.Controls.Add(this.lblName);
            this.pnlEmployeeProfile.Location = new System.Drawing.Point(-2, 2);
            this.pnlEmployeeProfile.Name = "pnlEmployeeProfile";
            this.pnlEmployeeProfile.Size = new System.Drawing.Size(592, 444);
            this.pnlEmployeeProfile.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewPassword.Location = new System.Drawing.Point(37, 328);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(195, 29);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOldPassword.Location = new System.Drawing.Point(35, 280);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(184, 29);
            this.lblOldPassword.TabIndex = 5;
            this.lblOldPassword.Text = "Old Password:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdress.Location = new System.Drawing.Point(35, 168);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(179, 29);
            this.lblAdress.TabIndex = 4;
            this.lblAdress.Text = "Address         :";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalary.Location = new System.Drawing.Point(37, 224);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(184, 29);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Salary            : ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(35, 122);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(179, 29);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone            :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(37, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(177, 29);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email             :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(35, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name             :";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(236, 284);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(212, 27);
            this.txtOldPassword.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(238, 330);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(212, 27);
            this.txtNewPassword.TabIndex = 8;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePassword.Location = new System.Drawing.Point(87, 386);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(203, 36);
            this.btnSavePassword.TabIndex = 9;
            this.btnSavePassword.Text = "Change Password";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(359, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 36);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.pnlEmployeeProfile);
            this.Name = "EmployeeProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Profile";
            this.pnlEmployeeProfile.ResumeLayout(false);
            this.pnlEmployeeProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.Button btnBack;
    }
}