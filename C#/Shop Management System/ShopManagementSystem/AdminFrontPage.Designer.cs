namespace ShopManagementSystem
{
    partial class AdminFrontPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInvoiceHistory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ShowDailySale = new System.Windows.Forms.Button();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.dtSearchDailySaleByDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDailySales = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlShowTopSellingProduct = new System.Windows.Forms.Panel();
            this.btnShowTopSellingProduct = new System.Windows.Forms.Button();
            this.lblSearchByProductId = new System.Windows.Forms.Label();
            this.txtSearchTopSellingProductByProductId = new System.Windows.Forms.TextBox();
            this.dgvTopSellingProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TolaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlShowTopSellingProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSellingProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnInvoiceHistory);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Location = new System.Drawing.Point(5, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 535);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.Location = new System.Drawing.Point(0, 324);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(333, 54);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(0, 270);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(333, 54);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Sales ";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 371);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(333, 53);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInvoiceHistory
            // 
            this.btnInvoiceHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoiceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceHistory.Location = new System.Drawing.Point(0, 216);
            this.btnInvoiceHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvoiceHistory.Name = "btnInvoiceHistory";
            this.btnInvoiceHistory.Size = new System.Drawing.Size(333, 54);
            this.btnInvoiceHistory.TabIndex = 4;
            this.btnInvoiceHistory.Text = "Invoice History";
            this.btnInvoiceHistory.UseVisualStyleBackColor = true;
            this.btnInvoiceHistory.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(0, 162);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(333, 54);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(0, 108);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(333, 54);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(0, 54);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(333, 54);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(333, 54);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.AliceBlue;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcome.Location = new System.Drawing.Point(11, 3);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1238, 60);
            this.lblWelcome.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(336, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 520);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pnlShowTopSellingProduct);
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(908, 518);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.ShowDailySale);
            this.panel5.Controls.Add(this.lblSearchByDate);
            this.panel5.Controls.Add(this.dtSearchDailySaleByDate);
            this.panel5.Controls.Add(this.dgvDailySales);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(465, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 514);
            this.panel5.TabIndex = 1;
            // 
            // ShowDailySale
            // 
            this.ShowDailySale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowDailySale.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDailySale.Location = new System.Drawing.Point(289, 21);
            this.ShowDailySale.Name = "ShowDailySale";
            this.ShowDailySale.Size = new System.Drawing.Size(95, 23);
            this.ShowDailySale.TabIndex = 7;
            this.ShowDailySale.Text = "SHOW";
            this.ShowDailySale.UseVisualStyleBackColor = true;
            this.ShowDailySale.Click += new System.EventHandler(this.ShowDailySale_Click);
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDate.Location = new System.Drawing.Point(278, 67);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(106, 15);
            this.lblSearchByDate.TabIndex = 4;
            this.lblSearchByDate.Text = "**Search By Date";
            // 
            // dtSearchDailySaleByDate
            // 
            this.dtSearchDailySaleByDate.Location = new System.Drawing.Point(218, 85);
            this.dtSearchDailySaleByDate.Name = "dtSearchDailySaleByDate";
            this.dtSearchDailySaleByDate.Size = new System.Drawing.Size(200, 22);
            this.dtSearchDailySaleByDate.TabIndex = 3;
            this.dtSearchDailySaleByDate.ValueChanged += new System.EventHandler(this.dtSearchDailySaleByDate_ValueChanged);
            // 
            // dgvDailySales
            // 
            this.dgvDailySales.AllowUserToAddRows = false;
            this.dgvDailySales.AllowUserToDeleteRows = false;
            this.dgvDailySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailySales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleDate,
            this.TolaSale});
            this.dgvDailySales.Location = new System.Drawing.Point(0, 112);
            this.dgvDailySales.Name = "dgvDailySales";
            this.dgvDailySales.ReadOnly = true;
            this.dgvDailySales.RowHeadersWidth = 51;
            this.dgvDailySales.RowTemplate.Height = 24;
            this.dgvDailySales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailySales.Size = new System.Drawing.Size(433, 406);
            this.dgvDailySales.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShopManagementSystem.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(118, -3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlShowTopSellingProduct
            // 
            this.pnlShowTopSellingProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlShowTopSellingProduct.Controls.Add(this.btnShowTopSellingProduct);
            this.pnlShowTopSellingProduct.Controls.Add(this.lblSearchByProductId);
            this.pnlShowTopSellingProduct.Controls.Add(this.txtSearchTopSellingProductByProductId);
            this.pnlShowTopSellingProduct.Controls.Add(this.dgvTopSellingProduct);
            this.pnlShowTopSellingProduct.Controls.Add(this.pictureBox1);
            this.pnlShowTopSellingProduct.Location = new System.Drawing.Point(-3, 0);
            this.pnlShowTopSellingProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlShowTopSellingProduct.Name = "pnlShowTopSellingProduct";
            this.pnlShowTopSellingProduct.Size = new System.Drawing.Size(462, 518);
            this.pnlShowTopSellingProduct.TabIndex = 0;
            // 
            // btnShowTopSellingProduct
            // 
            this.btnShowTopSellingProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowTopSellingProduct.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTopSellingProduct.Location = new System.Drawing.Point(310, 22);
            this.btnShowTopSellingProduct.Name = "btnShowTopSellingProduct";
            this.btnShowTopSellingProduct.Size = new System.Drawing.Size(95, 23);
            this.btnShowTopSellingProduct.TabIndex = 6;
            this.btnShowTopSellingProduct.Text = "SHOW";
            this.btnShowTopSellingProduct.UseVisualStyleBackColor = true;
            this.btnShowTopSellingProduct.Click += new System.EventHandler(this.btnShowTopSellingProduct_Click);
            // 
            // lblSearchByProductId
            // 
            this.lblSearchByProductId.AutoSize = true;
            this.lblSearchByProductId.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByProductId.Location = new System.Drawing.Point(295, 61);
            this.lblSearchByProductId.Name = "lblSearchByProductId";
            this.lblSearchByProductId.Size = new System.Drawing.Size(137, 15);
            this.lblSearchByProductId.TabIndex = 5;
            this.lblSearchByProductId.Text = "**Search By Product Id";
            // 
            // txtSearchTopSellingProductByProductId
            // 
            this.txtSearchTopSellingProductByProductId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTopSellingProductByProductId.Location = new System.Drawing.Point(281, 79);
            this.txtSearchTopSellingProductByProductId.Name = "txtSearchTopSellingProductByProductId";
            this.txtSearchTopSellingProductByProductId.Size = new System.Drawing.Size(151, 30);
            this.txtSearchTopSellingProductByProductId.TabIndex = 2;
            this.txtSearchTopSellingProductByProductId.TextChanged += new System.EventHandler(this.txtSearchTopSellingProductByProductId_TextChanged);
            // 
            // dgvTopSellingProduct
            // 
            this.dgvTopSellingProduct.AllowUserToAddRows = false;
            this.dgvTopSellingProduct.AllowUserToDeleteRows = false;
            this.dgvTopSellingProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSellingProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.TotalSold});
            this.dgvTopSellingProduct.Location = new System.Drawing.Point(3, 114);
            this.dgvTopSellingProduct.Name = "dgvTopSellingProduct";
            this.dgvTopSellingProduct.ReadOnly = true;
            this.dgvTopSellingProduct.RowHeadersWidth = 51;
            this.dgvTopSellingProduct.RowTemplate.Height = 24;
            this.dgvTopSellingProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSellingProduct.Size = new System.Drawing.Size(459, 406);
            this.dgvTopSellingProduct.TabIndex = 1;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // TotalSold
            // 
            this.TotalSold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSold.DataPropertyName = "TotalSold";
            this.TotalSold.HeaderText = "Total Sold";
            this.TotalSold.MinimumWidth = 6;
            this.TotalSold.Name = "TotalSold";
            this.TotalSold.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopManagementSystem.Properties.Resources.top_selling;
            this.pictureBox1.Location = new System.Drawing.Point(129, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Date";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // TolaSale
            // 
            this.TolaSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TolaSale.DataPropertyName = "TotalSale";
            this.TolaSale.HeaderText = "Total Sale";
            this.TolaSale.MinimumWidth = 6;
            this.TolaSale.Name = "TolaSale";
            this.TolaSale.ReadOnly = true;
            // 
            // AdminFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1251, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdminFrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFrontPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlShowTopSellingProduct.ResumeLayout(false);
            this.pnlShowTopSellingProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSellingProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInvoiceHistory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTopSale;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlShowTopSellingProduct;
        private System.Windows.Forms.DataGridView dgvTopSellingProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSold;
        private System.Windows.Forms.DataGridView dgvDailySales;
        private System.Windows.Forms.DateTimePicker dtSearchDailySaleByDate;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.TextBox txtSearchTopSellingProductByProductId;
        private System.Windows.Forms.Button btnShowTopSellingProduct;
        private System.Windows.Forms.Label lblSearchByProductId;
        private System.Windows.Forms.Button ShowDailySale;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TolaSale;
    }
}