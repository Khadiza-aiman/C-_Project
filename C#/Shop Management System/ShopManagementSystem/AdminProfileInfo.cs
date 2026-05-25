using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopManagementSystem
{
    public partial class AdminProfileInfo : Form
    {
        private DataAccess Da { get; set; }

        private AdminFrontPage af
        {
            get; set;
        }
        private string userId;
        public AdminProfileInfo()
        {
            InitializeComponent();

        }

        public AdminProfileInfo(string userId, AdminFrontPage af) : this()
        {
            this.af = af;
            this.userId = userId;
            this.SetInfo();


        }
        public void SetInfo()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "select * from UserInfo where Id = '" + this.userId + "';";
                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count == 1)
                {
                    this.txtUserId.Text = dt.Rows[0][0].ToString();
                    this.txtName.Text = dt.Rows[0]["UserName"].ToString();
                    this.txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    this.txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    this.txtPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
                    this.dtpDOB.Value = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"].ToString());
                    this.txtSalary.Text = dt.Rows[0]["Salary"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }

            this.txtUserId.ReadOnly = true;
            this.txtName.ReadOnly = true;
            this.txtEmail.ReadOnly = true;
            this.txtAddress.ReadOnly = true;
            this.txtPhoneNumber.ReadOnly = true;
            this.dtpDOB.Enabled = false;
            this.txtSalary.ReadOnly = true;

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            af.Visible = true;
        }

        private void SetTextBoxesReadOnly(bool isReadOnly)
        {
            
            this.txtName.ReadOnly = isReadOnly;
            this.txtEmail.ReadOnly = isReadOnly;
            this.txtAddress.ReadOnly = isReadOnly;
            this.txtPhoneNumber.ReadOnly = isReadOnly;
            this.dtpDOB.Enabled = !isReadOnly;
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(false);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Da = new DataAccess();
                var query = "select * from UserInfo where Id ='" + this.txtUserId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);
                
                var sql = @"update UserInfo
                               SET UserName = '" + this.txtName.Text + @"',
                                Email= '" + this.txtEmail.Text + @"',
                                Address = '" + this.txtAddress.Text + @"',
                                PhoneNumber = '" + this.txtPhoneNumber.Text + @"',
                                DateOfBirth= '" + this.dtpDOB.Value.ToString("yyyy-MM-dd") + @"',
                                Salary = '" + this.txtSalary.Text + @"'
                                where Id = '" + this.txtUserId.Text + "'; ";
                int result = this.Da.ExecuteDMLQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("Profile updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }

            SetTextBoxesReadOnly(true);



        }

        
    }
}

            
       

