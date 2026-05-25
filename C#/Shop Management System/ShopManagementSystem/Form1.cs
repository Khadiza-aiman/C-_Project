using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopManagementSystem
{
    public partial class LogIn : Form
    {


        private DataAccess Da { get; set; }

        public LogIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        internal void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from UserInfo where Id = '" + this.txtUserId.Text.ToLower() + "' and Password = '" + this.txtPassword.Text + "';";

                DataTable dt = this.Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count == 1)
                {
                    var userId = dt.Rows[0]["Id"].ToString();
                    var name = dt.Rows[0]["UserName"].ToString();

                    this.Hide();

                    string userType = dt.Rows[0]["Type"].ToString();

                    if (userType == "Admin")
                    {
                        new AdminFrontPage(userId, name, this).Show();
                    }
                    else if (userType == "Employee")
                    {
                        new Employee(userId, name, this).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Password");
                }

                txtUserId.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }


    }
}
