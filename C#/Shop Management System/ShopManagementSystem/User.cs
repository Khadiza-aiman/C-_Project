using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace ShopManagementSystem
{
    public partial class User : Form
    {
        private DataAccess Da
        {
            get; set;
        }

        private AdminFrontPage af
        {
            get; set;
        }
        public User()
        {
            InitializeComponent();
        }

        public User(AdminFrontPage af) : this()
        {
            this.af = af;
            this.Da = new DataAccess();
          
            string userType = this.cmbType.Text;
            
        }


        private void AutoIdGenerator(string Type)
        {
            try
            {
                string sql = "select max(Id) from UserInfo where Type ='" + Type + "';";
                var dt = this.Da.ExecuteQueryTable(sql);
                var oldId = dt.Rows[0][0].ToString();

                string prefix = (Type == "Admin") ? "A-" : "E-";
                int temp = 0;
                if (!string.IsNullOrEmpty(oldId))
                {
                    var s = oldId.Split('-');
                    temp = Convert.ToInt32(s[1]);
                }


                var newId = prefix + (temp + 1).ToString("d3");
                this.txtId.Text = newId;

            }

            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            af.Visible = true;
        }

        public void PopulataGridView(string sql = "select * from UserInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];


        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where Id = '" + this.txtSearch.Text + "';";
            this.PopulataGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill up all the information");
                    return;
                }

                var query = "select * from UserInfo Where Id = '" + this.txtId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"update UserInfo
                               SET UserName = '" + this.txtName.Text + @"',
                                Email= '" + this.txtEmail.Text + @"',
                                Address = '" + this.txtAddress.Text + @"',
                                PhoneNumber = '" + this.txtPhoneNumber.Text + @"',
                                DateOfBirth = '" + this.dtpDOB.Value.ToString("yyyy-MM-dd") + @"',
                                Salary = '" + this.txtSalary.Text + @"'
                                where Id = '" + this.txtId.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated");
                    }
                    else
                    {
                        MessageBox.Show("Data Updation Failed");
                    }
                }

                else
                {
                    var sql = @"insert into UserInfo
                                   (Id, UserName, Password, Address, PhoneNumber, DateOfBirth, Email,Salary, Type)
                                   values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" +
                                   this.txtPassword.Text + "', '" + this.txtAddress.Text + "', '" +
                                   this.txtPhoneNumber.Text + "', '" + this.dtpDOB.Value.ToString("yyyy-MM-dd") + "', '" +
                                   this.txtEmail.Text + "', '" + this.txtSalary.Text + "', '" + this.cmbType.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed");
                    }
                }

                this.PopulataGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulataGridView();
        }

        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtAddress.Clear();
            this.txtPhoneNumber.Clear();
            this.dtpDOB.Value = DateTime.Now;
            this.txtEmail.Clear();
            this.cmbType.SelectedIndex = -1;
            this.txtSalary.Clear();
            this.txtSearch.Clear();
            



        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) ||
                string.IsNullOrEmpty(this.txtAddress.Text) ||
                string.IsNullOrEmpty(this.txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(this.txtEmail.Text) ||
                this.cmbType.SelectedIndex == -1
                )
            {
                return false;
            }
            else
            {
                return true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete");
                    return;

                }

                var id = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvUser.CurrentRow.Cells[1].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure to delete " + name + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                    return;

                var sql = "delete from UserInfo where Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data Deleted");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }

                this.PopulataGridView();
                this.ClearAll();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.dgvUser.ClearSelection();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(this.cmbType.Text))
            {
                
                if (string.IsNullOrEmpty(this.txtId.Text))
                {
                    this.AutoIdGenerator(this.cmbType.Text);
                }
            }
        }

       


        private void dgvUser_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvUser.CurrentRow.Cells["Id"].Value.ToString();
            this.txtName.Text = this.dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
            this.txtPassword.Text = this.dgvUser.CurrentRow.Cells["Password"].Value.ToString();
            this.txtAddress.Text = this.dgvUser.CurrentRow.Cells["Address"].Value.ToString();
            this.txtPhoneNumber.Text = this.dgvUser.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            this.dtpDOB.Text = this.dgvUser.CurrentRow.Cells["DateOfBirth"].Value.ToString();
            this.txtEmail.Text = this.dgvUser.CurrentRow.Cells["Email"].Value.ToString();
            this.cmbType.Text = this.dgvUser.CurrentRow.Cells["Type"].Value.ToString();
            this.txtSalary.Text = this.dgvUser.CurrentRow.Cells["Salary"].Value.ToString();

        }
    }
}

