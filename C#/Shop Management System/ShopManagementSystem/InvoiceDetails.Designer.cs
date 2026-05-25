namespace ShopManagementSystem
{
    partial class InvoiceDetails
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
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.dtpSearchByDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchUserId = new System.Windows.Forms.TextBox();
            this.SearchBySellerId = new System.Windows.Forms.Label();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.lblSearchById = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.InvoiceDate,
            this.ProductList,
            this.TotalAmount,
            this.UserId});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(849, 345);
            this.dgvInvoice.TabIndex = 1;
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
            this.InvoiceDate.HeaderText = "Invoice Date";
            this.InvoiceDate.MinimumWidth = 6;
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            // 
            // ProductList
            // 
            this.ProductList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductList.DataPropertyName = "ProductList";
            this.ProductList.HeaderText = "Product List";
            this.ProductList.MinimumWidth = 6;
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "Seller User Id";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.White;
            this.pnlButton.Controls.Add(this.btnShow);
            this.pnlButton.Controls.Add(this.btnBack);
            this.pnlButton.Controls.Add(this.lblSearchByDate);
            this.pnlButton.Controls.Add(this.dtpSearchByDate);
            this.pnlButton.Controls.Add(this.txtSearchUserId);
            this.pnlButton.Controls.Add(this.SearchBySellerId);
            this.pnlButton.Controls.Add(this.txtSearchById);
            this.pnlButton.Controls.Add(this.lblSearchById);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 351);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(849, 132);
            this.pnlButton.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Green;
            this.btnShow.Location = new System.Drawing.Point(172, 81);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(119, 39);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBack.Location = new System.Drawing.Point(577, 81);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 39);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Close";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSearchByDate.Location = new System.Drawing.Point(585, 13);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(111, 16);
            this.lblSearchByDate.TabIndex = 11;
            this.lblSearchByDate.Text = "**Search By Date";
            // 
            // dtpSearchByDate
            // 
            this.dtpSearchByDate.Location = new System.Drawing.Point(588, 37);
            this.dtpSearchByDate.Name = "dtpSearchByDate";
            this.dtpSearchByDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSearchByDate.TabIndex = 10;
            this.dtpSearchByDate.ValueChanged += new System.EventHandler(this.dtpSearchByDate_ValueChanged);
            // 
            // txtSearchUserId
            // 
            this.txtSearchUserId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearchUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUserId.Location = new System.Drawing.Point(317, 32);
            this.txtSearchUserId.Name = "txtSearchUserId";
            this.txtSearchUserId.Size = new System.Drawing.Size(129, 27);
            this.txtSearchUserId.TabIndex = 9;
            this.txtSearchUserId.TextChanged += new System.EventHandler(this.txtSearchUserId_TextChanged);
            // 
            // SearchBySellerId
            // 
            this.SearchBySellerId.AutoSize = true;
            this.SearchBySellerId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBySellerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SearchBySellerId.Location = new System.Drawing.Point(314, 13);
            this.SearchBySellerId.Name = "SearchBySellerId";
            this.SearchBySellerId.Size = new System.Drawing.Size(165, 16);
            this.SearchBySellerId.TabIndex = 7;
            this.SearchBySellerId.Text = "**Search By Seller User ID";
            // 
            // txtSearchById
            // 
            this.txtSearchById.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearchById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchById.Location = new System.Drawing.Point(22, 32);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(129, 27);
            this.txtSearchById.TabIndex = 6;
            this.txtSearchById.TextChanged += new System.EventHandler(this.txtSearchById_TextChanged);
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchById.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSearchById.Location = new System.Drawing.Point(19, 13);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(141, 16);
            this.lblSearchById.TabIndex = 4;
            this.lblSearchById.Text = "**Search By Invoice ID";
            // 
            // InvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 483);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.dgvInvoice);
            this.MaximizeBox = false;
            this.Name = "InvoiceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Sales History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.DateTimePicker dtpSearchByDate;
        private System.Windows.Forms.TextBox txtSearchUserId;
        private System.Windows.Forms.Label SearchBySellerId;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.Button btnShow;
    }
}