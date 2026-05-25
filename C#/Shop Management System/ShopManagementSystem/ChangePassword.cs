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

namespace ShopManagementSystem
{
    public partial class ChangePassword : Form
    {
        private DataAccess Da { get; set; }
        private string userId;
        private AdminFrontPage af
        {
            get; set;
        }
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(string userId, AdminFrontPage af) : this()
        {
            this.af = af;
            this.Da = new DataAccess();
            this.userId = userId;
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            af.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = this.txtOldPassword.Text.Trim();
                string newPassword = this.txtNewPassword.Text.Trim();
                string confirmPassword = this.txtConfirmPass.Text.Trim();

                if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New password and confirm password do not match.");
                    return;
                }

                string sql = "select Password from UserInfo where Id = '" + this.userId + "' and Password = '" + oldPassword + "';";
                DataTable dt = this.Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count ==1 && dt.Rows[0]["Password"].ToString()==oldPassword)
                {
                    string updateSql = "update UserInfo set Password = '" + newPassword + "' where Id = '" + this.userId + "';";
                    int rows = this.Da.ExecuteDMLQuery(updateSql);
                    if (rows == 1)
                    {
                        MessageBox.Show("Password changed successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error updating password. Try again.");
                    }
                }

                else
                {
                    MessageBox.Show("Old password is incorrect.");
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
