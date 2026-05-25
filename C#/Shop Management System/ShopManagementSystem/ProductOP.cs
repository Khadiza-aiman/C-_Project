
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class ProductOP : Form
    {
        private DataAccess Da
        {
            get; set;
        }



        private AdminFrontPage af
        {
            get; set;
        }
        public ProductOP()
        {
            InitializeComponent();
        }
        public ProductOP(AdminFrontPage af) : this()
        {
            this.af = af;
            this.Da = new DataAccess();
        }

        private void AutoIdGenerator(string Gender, string ProductName, string Size)
        {
            try
            {
                if (string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(ProductName) || string.IsNullOrEmpty(Size))
                    return;

                string g = Gender.Substring(0, 1);
                string p = ProductName.Length >= 2 ? ProductName.Substring(0, 2) : ProductName.Substring(0, 1);
                string prefix = g + "-" + p + "-" + Size + "-";

                string sql = "select max(ProductID) from Product where ProductID like '" + prefix + "%';";
                var dt = this.Da.ExecuteQueryTable(sql);
                var oldId = dt.Rows[0][0].ToString();

                int temp = 0;
                if (!string.IsNullOrEmpty(oldId))
                {
                    var s = oldId.Split('-');
                    temp = Convert.ToInt32(s[s.Length - 1]);
                }

                var newId = prefix + (temp + 1).ToString("d3");
                this.txtProductId.Text = newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cmbSelectionChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtProductId.Text))
            {
                if (this.cmbGender.SelectedIndex != -1 &&
                    this.cmbProductName.SelectedIndex != -1 &&
                    this.cmbSize.SelectedIndex != -1)
                {
                    AutoIdGenerator(this.cmbGender.Text, this.cmbProductName.Text, this.cmbSize.Text);
                }
            }
        }

        public void PopulateGridView(string sql = "select * from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            af.Visible = true;
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductId.Text) ||
                string.IsNullOrEmpty(this.txtPrice.Text) ||
                string.IsNullOrEmpty(this.txtQuantity.Text) ||
                this.cmbGender.SelectedIndex == -1 ||
                this.cmbSize.SelectedIndex == -1 ||
                this.cmbProductName.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the fields correctly.");
                    return;
                }

                var query = "select * from Product where ProductID = '" + this.txtProductId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    var sql = @"update Product
                                set ProductName = '" + this.cmbProductName.Text + @"',
                                Gender = '" + this.cmbGender.Text + @"',
                                SellingPrice = '" + this.txtPrice.Text + @"',
                                Size = '" + this.cmbSize.Text + @"',
                                StockQuantity = '" + this.txtQuantity.Text + @"'
                                where ProductID = '" + this.txtProductId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Product information has been updated.");
                    else
                        MessageBox.Show("Data updation failed.");
                }
                else
                {
                    var sql = @"insert into Product
                                (ProductID, ProductName, Gender, SellingPrice, Size, StockQuantity)
                                values('" + this.txtProductId.Text + "', '" +
                                this.cmbProductName.Text + "', '" +
                                this.cmbGender.Text + "', '" +
                                this.txtPrice.Text + "', '" +
                                this.cmbSize.Text + "', '" +
                                this.txtQuantity.Text + "');";

                    var count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("New product has been added.");
                    else
                        MessageBox.Show("Data insertion failed.");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
        }

        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.cmbProductName.SelectedIndex = -1;
            this.cmbGender.SelectedIndex = -1;
            this.txtPrice.Clear();
            this.cmbSize.SelectedIndex = -1;
            this.txtQuantity.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first");
                    return;
                }

                var productId = this.dgvProduct.CurrentRow.Cells["ProductID"].Value.ToString();
                var name = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure to delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                    return;

                string sql = "DELETE FROM Product WHERE ProductID = '" + productId + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count >= 1)
                    MessageBox.Show("Product " + name + " has been deleted successfully.");
                else
                    MessageBox.Show("Data deletion failed.");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where ProductID = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }

        private void ProductOP_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
            this.cmbGender.SelectedIndexChanged += cmbSelectionChanged;
            this.cmbProductName.SelectedIndexChanged += cmbSelectionChanged;
            this.cmbSize.SelectedIndexChanged += cmbSelectionChanged;
        }

        private void dgvProduct_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtProductId.Text = this.dgvProduct.CurrentRow.Cells["ProductID"].Value.ToString();
            this.cmbProductName.Text = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbGender.Text = this.dgvProduct.CurrentRow.Cells["Gender"].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.cmbSize.Text = this.dgvProduct.CurrentRow.Cells["Size"].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells["StockQuantity"].Value.ToString();
        }

    }
}
