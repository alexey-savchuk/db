using Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (!IsValidEmail(email) || !IsValidPassword(password))
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Database db = new Database();

            try
            {
                db.OpenConnection();

                string query = $"SELECT member_id, email, role_name FROM member M" +
                               $" INNER JOIN member_role R ON R.role_id = M.role_id" +
                               $" WHERE M.email = N'{email}'";

                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    MemberInfo.memberId = reader["member_id"].ToString();
                    MemberInfo.email = reader["email"].ToString();
                    MemberInfo.role = reader["role_name"].ToString();
                }
                else
                {
                    MessageBox.Show("Не удалось войти в систему", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                db.CloseConnection();
                return;
            }

            if (MemberInfo.role == "USER")
            {
                UserForms.Dashboard dashboard = new UserForms.Dashboard();
                Hide();
                dashboard.Show();
            }
            else if (MemberInfo.role == "STAFF")
            {
                StaffForms.Dashboard dashboard = new StaffForms.Dashboard();
                Hide();
                dashboard.Show();
            }
            else if (MemberInfo.role == "ADMIN")
            {
                AdminForms.Dashboard dashboard = new AdminForms.Dashboard();
                Hide();
                dashboard.Show();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPassword(string password)
        {
            return true;
        }
    }
}
