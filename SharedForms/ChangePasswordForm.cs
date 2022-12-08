using Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.SharedForms
{
    public partial class ChangePasswordForm : Form
    {
        Database database = new Database();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            char ch = oldPasswordTextBox.PasswordChar;
            oldPasswordTextBox.PasswordChar = (ch == '*' ? '\0' : '*');
        }

        private void showPasswordCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            char ch = newPasswordTextBox.PasswordChar;
            newPasswordTextBox.PasswordChar = (ch == '*' ? '\0' : '*');
        }

        private void SubmitPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordEncoder encoder = new PasswordEncoder();

            String oldPassword = encoder.Encode(oldPasswordTextBox.Text);
            String newPassword = encoder.Encode(newPasswordTextBox.Text);

            String email = MemberInfo.email;

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM member WHERE email = N'{email}' AND password = N'{oldPassword}'";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();

                    Debug.WriteLine(oldPassword);
                    Debug.WriteLine(newPassword);

                    query = $"UPDATE member SET password = N'{newPassword}' WHERE email = N'{email}'";
                    cmd = new SqlCommand(query, database.GetConnection());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Успех", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
