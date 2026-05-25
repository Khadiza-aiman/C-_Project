using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class InvoiceDetails : Form
    {
        private DataAccess Da { get; set; }
        private AdminFrontPage AdminFornt { get; set; }

        public InvoiceDetails()
        {
            InitializeComponent();
            Da = new DataAccess();
            LoadAllInvoices();
        }
        public InvoiceDetails(AdminFrontPage af):this()
        {
            AdminFornt = af;
        }

        private void LoadAllInvoices()
        {
            try
            {
                string sql = "Select * from Invoice ORDER BY InvoiceDate DESC";
                DataSet ds = Da.ExecuteQuery(sql);
                dgvInvoice.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoices: " + ex.Message);
            }
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string invoiceId = txtSearchById.Text.Trim();
                if (string.IsNullOrEmpty(invoiceId))
                {
                    LoadAllInvoices();
                    return;
                }
                string sql = "SELECT InvoiceID, InvoiceDate, ProductList, TotalAmount, UserID FROM Invoice WHERE InvoiceID LIKE '%" + invoiceId + "%'";
                DataSet ds = Da.ExecuteQuery(sql);
                dgvInvoice.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching by Invoice ID: " + ex.Message);
            }
        }



        private void txtSearchUserId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string userId = txtSearchUserId.Text.Trim();
                if (string.IsNullOrEmpty(userId))
                {
                    LoadAllInvoices();
                    return;
                }
                string sql = "SELECT InvoiceID, InvoiceDate, ProductList, TotalAmount, UserID FROM Invoice WHERE UserID LIKE '%" + userId + "%'";
                DataSet ds = Da.ExecuteQuery(sql);
                dgvInvoice.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching by User ID: " + ex.Message);
            }
        }



        private void dtpSearchByDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpSearchByDate.Value.Date;
                string sql = "SELECT InvoiceID, InvoiceDate, ProductList, TotalAmount, UserID FROM Invoice WHERE CAST(InvoiceDate AS DATE) = '" + date.ToString("yyyy-MM-dd") + "'";
                DataSet ds = Da.ExecuteQuery(sql);
                dgvInvoice.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching invoices by Date: " + ex.Message);
            }
        }

        /*private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                 this.AdminFornt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing form: " + ex.Message);
            }
        }*/
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.AdminFornt.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning to the Admin page: " + ex.Message);
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            txtSearchById.Clear();
            txtSearchUserId.Clear();
            LoadAllInvoices();
        }
    }
}
