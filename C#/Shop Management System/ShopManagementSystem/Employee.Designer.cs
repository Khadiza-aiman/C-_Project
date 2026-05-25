namespace ShopManagementSystem
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlShowSellingHistory = new System.Windows.Forms.Panel();
            this.gdvShowHistory = new System.Windows.Forms.DataGridView();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSellsHistory = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lblSearchByInvoiceId = new System.Windows.Forms.Label();
            this.txtSearchByInvoiceID = new System.Windows.Forms.TextBox();
            this.lblSearchByDateAndTime = new System.Windows.Forms.Label();
            this.dtSearchHistory = new System.Windows.Forms.DateTimePicker();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlShowSellingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvShowHistory)).BeginInit();
            this.pnlHistory.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShowSellingHistory
            // 
            this.pnlShowSellingHistory.AutoSize = true;
            this.pnlShowSellingHistory.Controls.Add(this.gdvShowHistory);
            this.pnlShowSellingHistory.Location = new System.Drawing.Point(318, 123);
            this.pnlShowSellingHistory.Name = "pnlShowSellingHistory";
            this.pnlShowSellingHistory.Size = new System.Drawing.Size(383, 324);
            this.pnlShowSellingHistory.TabIndex = 0;
            // 
            // gdvShowHistory
            // 
            this.gdvShowHistory.AllowUserToAddRows = false;
            this.gdvShowHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvShowHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvShowHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvShowHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.InvoiceDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvShowHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdvShowHistory.Location = new System.Drawing.Point(0, 0);
            this.gdvShowHistory.Name = "gdvShowHistory";
            this.gdvShowHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvShowHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gdvShowHistory.RowHeadersWidth = 51;
            this.gdvShowHistory.RowTemplate.Height = 24;
            this.gdvShowHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvShowHistory.Size = new System.Drawing.Size(380, 321);
            this.gdvShowHistory.TabIndex = 0;
            // 
            // InvoiceId
            // 
            this.InvoiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "Invoice ID";
            this.InvoiceId.MinimumWidth = 6;
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "Date";
            this.InvoiceDate.MinimumWidth = 6;
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            // 
            // lblSellsHistory
            // 
            this.lblSellsHistory.AutoSize = true;
            this.lblSellsHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellsHistory.Location = new System.Drawing.Point(3, 7);
            this.lblSellsHistory.Name = "lblSellsHistory";
            this.lblSellsHistory.Size = new System.Drawing.Size(167, 29);
            this.lblSellsHistory.TabIndex = 1;
            this.lblSellsHistory.Text = "Sales History";
            // 
            // pnlHistory
            // 
            this.pnlHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHistory.Controls.Add(this.lblSearchByInvoiceId);
            this.pnlHistory.Controls.Add(this.txtSearchByInvoiceID);
            this.pnlHistory.Controls.Add(this.lblSearchByDateAndTime);
            this.pnlHistory.Controls.Add(this.dtSearchHistory);
            this.pnlHistory.Controls.Add(this.lblSellsHistory);
            this.pnlHistory.Location = new System.Drawing.Point(318, 2);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(380, 115);
            this.pnlHistory.TabIndex = 1;
            // 
            // lblSearchByInvoiceId
            // 
            this.lblSearchByInvoiceId.AutoSize = true;
            this.lblSearchByInvoiceId.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchByInvoiceId.Location = new System.Drawing.Point(5, 87);
            this.lblSearchByInvoiceId.Name = "lblSearchByInvoiceId";
            this.lblSearchByInvoiceId.Size = new System.Drawing.Size(143, 16);
            this.lblSearchByInvoiceId.TabIndex = 5;
            this.lblSearchByInvoiceId.Text = "Search By Invoice Id>>";
            // 
            // txtSearchByInvoiceID
            // 
            this.txtSearchByInvoiceID.Location = new System.Drawing.Point(169, 81);
            this.txtSearchByInvoiceID.Name = "txtSearchByInvoiceID";
            this.txtSearchByInvoiceID.Size = new System.Drawing.Size(200, 22);
            this.txtSearchByInvoiceID.TabIndex = 4;
            this.txtSearchByInvoiceID.TextChanged += new System.EventHandler(this.txtSearchByInvoiceID_TextChanged);
            // 
            // lblSearchByDateAndTime
            // 
            this.lblSearchByDateAndTime.AutoSize = true;
            this.lblSearchByDateAndTime.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchByDateAndTime.Location = new System.Drawing.Point(33, 45);
            this.lblSearchByDateAndTime.Name = "lblSearchByDateAndTime";
            this.lblSearchByDateAndTime.Size = new System.Drawing.Size(115, 16);
            this.lblSearchByDateAndTime.TabIndex = 3;
            this.lblSearchByDateAndTime.Text = "Search By Date>>";
            // 
            // dtSearchHistory
            // 
            this.dtSearchHistory.Location = new System.Drawing.Point(169, 39);
            this.dtSearchHistory.Name = "dtSearchHistory";
            this.dtSearchHistory.Size = new System.Drawing.Size(200, 22);
            this.dtSearchHistory.TabIndex = 2;
            this.dtSearchHistory.ValueChanged += new System.EventHandler(this.dtSearchHistory_ValueChanged);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProfile.Controls.Add(this.btnShow);
            this.pnlProfile.Controls.Add(this.btnLogOut);
            this.pnlProfile.Controls.Add(this.btnSales);
            this.pnlProfile.Controls.Add(this.btnProfile);
            this.pnlProfile.Controls.Add(this.lblWelcome);
            this.pnlProfile.Location = new System.Drawing.Point(0, 2);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(315, 442);
            this.pnlProfile.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(215, 229);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 41);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(34, 278);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(171, 45);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSales
            // 
            this.btnSales.AutoSize = true;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Red;
            this.btnSales.Location = new System.Drawing.Point(34, 171);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(171, 45);
            this.btnSales.TabIndex = 8;
            this.btnSales.Text = "Go To sells";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSize = true;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(34, 81);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(171, 45);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcome.Location = new System.Drawing.Point(12, 7);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(102, 25);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlShowSellingHistory);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.pnlShowSellingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvShowHistory)).EndInit();
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowSellingHistory;
        private System.Windows.Forms.Label lblSellsHistory;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.DateTimePicker dtSearchHistory;
        private System.Windows.Forms.Label lblSearchByInvoiceId;
        private System.Windows.Forms.TextBox txtSearchByInvoiceID;
        private System.Windows.Forms.Label lblSearchByDateAndTime;
        private System.Windows.Forms.DataGridView gdvShowHistory;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.Button btnShow;
    }
}