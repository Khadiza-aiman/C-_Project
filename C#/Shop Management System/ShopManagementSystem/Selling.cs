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
    public partial class Selling : Form
    {
        private DataAccess Da { get; set; }
        private string UserId { get; set; }
        private string UserName { get; set; }
        private AdminFrontPage AdminFrontPage { get; set; }
        private Employee Employee { get; set; }

        public Selling()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
            AutoIdGenerate();
        }

        public Selling(string userId, string userName, AdminFrontPage af) : this()
        {
            this.UserId = userId;
            this.UserName = userName;
            this.AdminFrontPage = af;
            lblWelcome.Text += " " + userName;
        }

        public Selling(string userId, string userName, Employee e) : this()
        {
            this.UserId = userId;
            this.UserName = userName;
            this.Employee = e;
            lblWelcome.Text += " " + userName;
        }

        private void PopulateGridView(string sql = "")
        {
            if (string.IsNullOrEmpty(sql))
            {
                sql = "SELECT ProductID, ProductName, Gender, Size, SellingPrice, StockQuantity AS AvailableProduct FROM Product WHERE StockQuantity > 0";
            }
            var ds = Da.ExecuteQuery(sql);
            dgvShowing.AutoGenerateColumns = false;
            dgvShowing.DataSource = ds.Tables[0];
        }

        private void AutoIdGenerate()
        {
            try
            {
                var dt = Da.ExecuteQueryTable("SELECT MAX(InvoiceID) FROM Invoice;");
                if (dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value || string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                {
                    lblShowInvoiceId.Text = "INV-001";
                    return;
                }
                string oldId = dt.Rows[0][0].ToString();
                var split = oldId.Split('-');
                if (split.Length < 2 || !int.TryParse(split[1], out int id))
                {
                    lblShowInvoiceId.Text = "INV-001";
                    return;
                }
                id++;
                lblShowInvoiceId.Text = "INV-" + id.ToString("D3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Invoice ID: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowing.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product first.");
                    return;
                }

                var selectedRow = dgvShowing.CurrentRow;
                string productId = selectedRow.Cells["ProductID"].Value.ToString();
                string size = selectedRow.Cells["Size"].Value.ToString();

                
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string existingProductId = row.Cells["ProductId_Invoice"].Value.ToString();
                        string existingSize = row.Cells["SizeInInvoice"].Value.ToString();
                        if (existingProductId == productId && existingSize == size)
                        {
                            MessageBox.Show("This product with the same size is already added.");
                            return;
                        }
                    }
                }

                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                int quantity = 1;
                double unitPrice = Convert.ToDouble(selectedRow.Cells["SellingPrice"].Value);
                double totalPrice = unitPrice * quantity;
                int availableProduct = Convert.ToInt32(selectedRow.Cells["AvailableProduct"].Value);

                dgvInvoice.Rows.Add(productId, productName, size, unitPrice, quantity, totalPrice);

                if (dgvInvoice.CurrentRow != null)
                {
                    UpDownQuantity.Maximum = availableProduct;
                    UpDownQuantity.Value = quantity;
                }

                UpdateNetAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void dgvInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInvoice.Columns[e.ColumnIndex].Name == "ProductQuantity_Invoice" && !dgvInvoice.Rows[e.RowIndex].IsNewRow)
                {
                    var row = dgvInvoice.Rows[e.RowIndex];
                    if (!int.TryParse(row.Cells["ProductQuantity_Invoice"].Value?.ToString(), out int qty) || qty < 1)
                    {
                        MessageBox.Show("Quantity must be a positive integer.");
                        row.Cells["ProductQuantity_Invoice"].Value = 1;
                        qty = 1;
                    }

                    int maxQty = Convert.ToInt32(dgvShowing.SelectedRows[0].Cells["AvailableProduct"].Value);

                    if (qty > maxQty)
                    {
                        MessageBox.Show("Quantity exceeds available stock.");
                        row.Cells["ProductQuantity_Invoice"].Value = maxQty;
                        qty = maxQty;
                    }

                    double price = Convert.ToDouble(row.Cells["SellingPrice_ProductQuantity"].Value);
                    row.Cells["TotalPrice_Invoice"].Value = qty * price;

                    if (dgvInvoice.CurrentRow == row)
                    {
                        UpDownQuantity.Value = qty;
                        UpDownQuantity.Maximum = maxQty;
                    }

                    UpdateNetAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating quantity: " + ex.Message);
            }
        }

        private void UpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.CurrentRow != null)
                {
                    int qty = Convert.ToInt32(UpDownQuantity.Value);
                    int maxQty = Convert.ToInt32(dgvShowing.SelectedRows[0].Cells["AvailableProduct"].Value);

                    if (qty < 1)
                    {
                        MessageBox.Show("Quantity must be at least 1.");
                        UpDownQuantity.Value = 1;
                        qty = 1;
                    }
                    else if (qty > maxQty)
                    {
                        MessageBox.Show("Quantity exceeds available stock.");
                        UpDownQuantity.Value = maxQty;
                        qty = maxQty;
                    }

                    dgvInvoice.CurrentRow.Cells["ProductQuantity_Invoice"].Value = qty;
                    double price = Convert.ToDouble(dgvInvoice.CurrentRow.Cells["SellingPrice_ProductQuantity"].Value);
                    dgvInvoice.CurrentRow.Cells["TotalPrice_Invoice"].Value = qty * price;
                    UpdateNetAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating quantity: " + ex.Message);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(lblShowNetAmmount.Text, out double netAmount) || netAmount < 0)
                {
                    MessageBox.Show("Invalid net amount.");
                    return;
                }
                if (!double.TryParse(txtAmount.Text, out double paid) || paid < netAmount)
                {
                    MessageBox.Show("Paid amount must be equal or greater than net amount.");
                    return;
                }
                double change = paid - netAmount;
                lblShowChangeAmmount.Text = change.ToString("F2");
                lblShowAmmount.Text = paid.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating change: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.SelectedRows.Count > 0)
                {
                    dgvInvoice.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
                    UpdateNetAmount();
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item: " + ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.Rows.Count == 0)
                {
                    MessageBox.Show("Please add products before confirming.");
                    return;
                }
                if (string.IsNullOrEmpty(lblShowNetAmmount.Text) || string.IsNullOrEmpty(txtAmount.Text))
                {
                    MessageBox.Show("Please enter payment information.");
                    return;
                }
                SaveInvoice();
                ClearAll();
                AdminFrontPage a=new AdminFrontPage();
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming purchase: " + ex.Message);
            }
        }

        private void SaveInvoice()
        {
            try
            {
                if (string.IsNullOrEmpty(UserId))
                {
                    MessageBox.Show("User ID not set. Cannot save invoice without user association.");
                    return;
                }

                string invoiceId = lblShowInvoiceId.Text;
                string invoiceDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                var productListItems = new List<string>();
                double totalAmount = 0;

                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    if (row.IsNewRow) continue;

                    string productId = row.Cells["ProductId_Invoice"].Value.ToString();
                    string size = row.Cells["SizeInInvoice"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["ProductQuantity_Invoice"].Value);
                    double price = Convert.ToDouble(row.Cells["SellingPrice_ProductQuantity"].Value);
                    double totalPrice = price * quantity;

                    productListItems.Add($"{productId}-{quantity}");

                    string updateStockSql = "UPDATE Product SET StockQuantity = StockQuantity - "
                    + quantity + " WHERE ProductID = '"
                     + productId + "' ";

                    Da.ExecuteDMLQuery(updateStockSql);

                    totalAmount += totalPrice;
                }

                string productList = string.Join(",", productListItems);

                
                string insertInvoiceSql = "INSERT INTO Invoice (InvoiceID, InvoiceDate, ProductList, TotalAmount, UserID) VALUES ('"
                 + invoiceId + "', '"
                 + invoiceDate + "', '"
                 + productList + "', "
                 + totalAmount + ", '"
                 + UserId + "')";


                if (Da.ExecuteDMLQuery(insertInvoiceSql) != 1)
                {
                    MessageBox.Show("Failed to save invoice.");
                    return;
                }

                MessageBox.Show("Purchase successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving invoice: " + ex.Message);
            }
        }

        private void UpdateNetAmount()
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    if (row.IsNewRow) continue;
                    total += Convert.ToDouble(row.Cells["TotalPrice_Invoice"].Value);
                }
                lblShowNetAmmount.Text = total.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating net amount: " + ex.Message);
            }
        }

        private void ClearAll()
        {
            dgvInvoice.Rows.Clear();
            lblShowNetAmmount.Text = "0";
            txtAmount.Clear();
            lblShowChangeAmmount.Text = "0";
            lblShowAmmount.Text = "0";
            UpDownQuantity.Value = 0;
            txtSearchByProuctName.Clear();
            txtSearchByID.Clear();
            cmbSearchByGender.SelectedIndex = 0;

            AutoIdGenerate();
            PopulateGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void cmbSearchByGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gender = cmbSearchByGender.SelectedItem?.ToString();
            string sql = "SELECT ProductID, ProductName, Gender, Size, SellingPrice, StockQuantity AS AvailableProduct FROM Product WHERE StockQuantity > 0";
            if (!string.IsNullOrEmpty(gender) && gender != "All")
            {
                sql += " AND Gender = '" + gender + "'";
            }
            PopulateGridView(sql);
        }

        private void txtSearchByProuctName_TextChanged(object sender, EventArgs e)
        {
            string productName = txtSearchByProuctName.Text.Trim();
            string sql = "SELECT ProductID, ProductName, Gender, Size, SellingPrice, StockQuantity AS AvailableProduct FROM Product WHERE StockQuantity > 0";
            if (!string.IsNullOrEmpty(productName))
            {
                sql += " AND ProductName LIKE '%" + productName + "%'";
            }
            PopulateGridView(sql);
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            string productId = txtSearchByID.Text.Trim();
            string sql = "SELECT ProductID, ProductName, Gender, Size, SellingPrice, StockQuantity AS AvailableProduct FROM Product WHERE StockQuantity > 0";
            if (!string.IsNullOrEmpty(productId))
            {
                sql += " AND ProductID LIKE '%" + productId + "%'";
            }
            PopulateGridView(sql);
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            string productId = txtSearchByID.Text.Trim();
            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Please enter a Product ID");
                return;
            }
            string sql = "SELECT ProductID, ProductName, Gender, Size, SellingPrice, StockQuantity AS AvailableProduct FROM Product WHERE StockQuantity > 0 AND ProductID = '" + productId + "'";
            PopulateGridView(sql);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Type FROM UserInfo WHERE ID = '" + UserId + "'";
                var dt = Da.ExecuteQueryTable(query);
                string userType = "";

                if (dt.Rows.Count > 0)
                {
                    userType = dt.Rows[0]["Type"].ToString();
                }

                if (userType == "Admin")
                {
                    if (AdminFrontPage != null)
                    {
                        AdminFrontPage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Admin page reference missing.");
                    }
                }
                else
                {
                    if (Employee != null)
                    {
                        Employee.Show();
                    }
                    else
                    {
                        MessageBox.Show("Employee page reference missing.");
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during back navigation: " + ex.Message);
            }
        }

        
    }
}
