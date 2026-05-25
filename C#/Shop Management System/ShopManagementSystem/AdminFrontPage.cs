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
    public partial class AdminFrontPage : Form
    {

        private DataAccess Da { get; set; }

        private string userId;
        private string name;

        private LogIn l { get; set; }

        private User u { get; set; }

        public AdminFrontPage()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.LoadTopSellingProduct();
            this.LoadDailySales();
        }

        public AdminFrontPage(string userId, string name, LogIn l) : this()
        {
            this.userId = userId;
            this.name = name;
            this.l = l;
            this.lblWelcome.Text = "Welcome, " + this.name;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminProfileInfo ap = new AdminProfileInfo(this.userId, this);
            ap.Visible = true;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            User u = new User(this);
            u.Show();
            u.PopulataGridView();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangePassword cp = new ChangePassword(this.userId, this);
            cp.Visible = true;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvoiceDetails inv = new InvoiceDetails(this);
            inv.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ProductOP po = new ProductOP(this);
            po.Show();
            po.PopulateGridView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Logged out from the system");
            this.l.Visible = true;
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Selling s = new Selling(this.userId, this.name, this);
            s.Visible = true;
        }

        private void LoadTopSellingProduct(string sql = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sql))
                    sql = "SELECT ProductList FROM Invoice";

                DataTable dtInvoices = this.Da.ExecuteQueryTable(sql);

                var productSales = new Dictionary<string, int>();

                foreach (DataRow row in dtInvoices.Rows)
                {
                    string productList = row["ProductList"].ToString();
                    if (string.IsNullOrEmpty(productList)) continue;

                    string[] products = productList.Split(',');

                    foreach (string prod in products)
                    {
                        string[] parts = prod.Split('-');
                        if (parts.Length < 2) continue;

                        string productId = string.Join("-", parts.Take(parts.Length - 1));
                        if (!int.TryParse(parts.Last(), out int quantity))
                            quantity = 0;

                        if (quantity > 0)
                        {
                            if (productSales.ContainsKey(productId))
                                productSales[productId] += quantity;
                            else
                                productSales[productId] = quantity;
                        }
                    }
                }

                DataTable dtTopProducts = new DataTable();
                dtTopProducts.Columns.Add("ProductID");
                dtTopProducts.Columns.Add("ProductName");
                dtTopProducts.Columns.Add("TotalSold", typeof(int));

                foreach (var item in productSales.OrderByDescending(x => x.Value).Take(10))
                {
                    string productId = item.Key;
                    int totalSold = item.Value;

                    string sqlProduct = "SELECT ProductName FROM Product WHERE ProductID = '" + productId + "'";
                    DataTable dtProduct = this.Da.ExecuteQueryTable(sqlProduct);

                    string productName = dtProduct.Rows.Count > 0 ? dtProduct.Rows[0]["ProductName"].ToString() : "Unknown";

                    dtTopProducts.Rows.Add(productId, productName, totalSold);
                }

                this.dgvTopSellingProduct.AutoGenerateColumns = false;
                this.dgvTopSellingProduct.DataSource = dtTopProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading top selling products: " + ex.Message);
            }
        }

    

        private void txtSearchTopSellingProductByProductId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = this.txtSearchTopSellingProductByProductId.Text.Trim();

                if (string.IsNullOrEmpty(search))
                {
                    LoadTopSellingProduct();
                    return;
                }

                string sqlInvoices = "SELECT ProductList FROM Invoice WHERE ProductList LIKE '%" + search + "%';";
                LoadTopSellingProduct(sqlInvoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

   

        private void LoadDailySales(string sql = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sql))
                {
                    sql = @"
                SELECT CAST(InvoiceDate AS DATE) AS SaleDate, SUM(TotalAmount) AS TotalSale
                FROM Invoice
                GROUP BY CAST(InvoiceDate AS DATE)
                ORDER BY SaleDate DESC";
                }

                DataTable dt = this.Da.ExecuteQueryTable(sql);

                this.dgvDailySales.AutoGenerateColumns = false;
                this.dgvDailySales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading daily sales summary: " + ex.Message);
            }
        }

        private void dtSearchDailySaleByDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedDate = this.dtSearchDailySaleByDate.Value.ToString("yyyy-MM-dd");

                string sql = "SELECT CAST(InvoiceDate AS DATE) AS SaleDate, SUM(TotalAmount) AS TotalSale " +
                             "FROM Invoice WHERE CAST(InvoiceDate AS DATE) = '" + selectedDate + "' " +
                             "GROUP BY CAST(InvoiceDate AS DATE) ORDER BY SaleDate DESC;";

                LoadDailySales(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering daily sales: " + ex.Message);
            }
        }


        private void btnShowTopSellingProduct_Click(object sender, EventArgs e)
        {
            this.txtSearchTopSellingProductByProductId.Clear();
            this.LoadTopSellingProduct();
        }

        private void ShowDailySale_Click(object sender, EventArgs e)
        {
            this.dtSearchDailySaleByDate.Value = DateTime.Today;
            this.LoadDailySales();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSearchTopSellingProductByProductId.Clear();
            this.dtSearchDailySaleByDate.Value = DateTime.Today;

            this.LoadTopSellingProduct();
            this.LoadDailySales();
        }
    }
}
