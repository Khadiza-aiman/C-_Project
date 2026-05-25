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
    public partial class EmployeeProfile : Form
    {

        private Employee Em { get; set; }
        private string UserId { get; set; }
        private DataAccess Da { get; set; }

        public EmployeeProfile()
        {
            InitializeComponent();
            Da = new DataAccess();
        }

        public EmployeeProfile(string userId, Employee em) : this()
        {
            this.UserId = userId;
            this.Em = em;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                string sql = "SELECT UserName, Address, Salary, PhoneNumber, Email FROM UserInfo WHERE ID = '" + UserId + "'";
                DataTable dt = Da.ExecuteQueryTable(sql);
                if (dt.Rows.Count > 0)
                {
                    
                    lblName.Text += dt.Rows[0]["UserName"].ToString();
                    lblAdress.Text += dt.Rows[0]["Address"].ToString();
                    lblSalary.Text  += dt.Rows[0]["Salary"].ToString();
                    lblPhoneNumber.Text  += dt.Rows[0]["PhoneNumber"].ToString();
                    lblEmail.Text += dt.Rows[0]["Email"].ToString();



                }
                else
                {
                    MessageBox.Show("User info not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user info: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Em.Show();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPass = txtOldPassword.Text.Trim();
                string newPass = txtNewPassword.Text.Trim();

                if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass))
                {
                    MessageBox.Show("Please enter both old and new password.");
                    return;
                }

                
                string sqlVerify = "SELECT Password FROM UserInfo WHERE ID = '" + UserId + "'";
                DataTable dt = Da.ExecuteQueryTable(sqlVerify);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                string currentPass = dt.Rows[0]["Password"].ToString();

                if (currentPass != oldPass)
                {
                    MessageBox.Show("Old password is incorrect.");
                    return;
                }

                
                string sqlUpdate = "UPDATE UserInfo SET Password = '" + newPass + "' WHERE ID = '" + UserId + "'";
                int result = Da.ExecuteDMLQuery(sqlUpdate);

                if (result == 1)
                {
                    MessageBox.Show("Password updated successfully.");
                    txtOldPassword.Clear();
                    txtNewPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }

        }
    }
}
