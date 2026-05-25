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
    public partial class Employee : Form
    {

        
        private DataAccess Da { get; set; }
        private LogIn La { get; set; }
        private string UserId { get; set; }
        private string EmpName { get; set; }

        public Employee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            

        }

        public Employee(string userId, string empName, LogIn la) : this()
        {
            this.UserId = userId;
            this.EmpName = empName;
            this.La = la;
            this.lblWelcome.Text += " " + this.EmpName;
            this.PopulateGridView();
        }

        
       
        private void PopulateGridView(string sql = "")
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                    sql = "SELECT InvoiceID, InvoiceDate FROM Invoice WHERE UserID = '" + this.UserId + "' ORDER BY InvoiceDate DESC;";

                var ds = this.Da.ExecuteQuery(sql);
                this.gdvShowHistory.AutoGenerateColumns = false;
                this.gdvShowHistory.DataSource = ds.Tables[0];

                if (gdvShowHistory.Columns.Contains("InvoiceID"))
                    this.gdvShowHistory.Columns["InvoiceID"].DataPropertyName = "InvoiceID";

                if (gdvShowHistory.Columns.Contains("InvoiceDate"))
                    this.gdvShowHistory.Columns["InvoiceDate"].DataPropertyName = "InvoiceDate";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoices: " + ex.Message);
            }
        }

        private void dtSearchHistory_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtSearchHistory.Value.Date;
                string sql = "SELECT InvoiceID, InvoiceDate FROM Invoice WHERE UserID = '" + this.UserId
                           + "' AND CAST(InvoiceDate AS DATE) = '" + date.ToString("yyyy-MM-dd")
                           + "' ORDER BY InvoiceDate DESC;";

                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying date filter: " + ex.Message);
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Selling selling = new Selling(this.UserId, this.EmpName, this);
                selling.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening sales window: " + ex.Message);
                this.Show();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MessageBox.Show("Logged out from the system");
                this.La.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message);
            }
        }

        private void txtSearchByInvoiceID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = this.txtSearchByInvoiceID.Text.Trim();
                if (string.IsNullOrEmpty(search))
                {
                    this.PopulateGridView();
                    return;
                }
                string sql = "SELECT InvoiceID, InvoiceDate FROM Invoice WHERE UserID = '" + this.UserId + "' AND InvoiceID LIKE '%" + search + "%' ORDER BY InvoiceDate DESC;";
                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching invoices: " + ex.Message);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                EmployeeProfile profile = new EmployeeProfile(this.UserId, this);
                profile.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening profile: " + ex.Message);
                this.Show();
            }
        }

        
        private void ClearAll()
        {
            this.txtSearchByInvoiceID.Clear();
            this.dtSearchHistory.Value = DateTime.Today;
            this.gdvShowHistory.ClearSelection();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtSearchByInvoiceID.Clear();
            dtSearchHistory.Value = DateTime.Today;
            PopulateGridView();
        }

        
    }

}

