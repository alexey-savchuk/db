using Library.Utils;
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

namespace Library.AdminForms
{
    public partial class RegisterForm : Form
    {
        Database database = new Database();
        PasswordEncoder encoder = new PasswordEncoder();

        public RegisterForm()
        {
            InitializeComponent();
            InitRoles();
            roleComboBox.SelectedItem = roleComboBox.Items[0];
        }

        private void SubmitRegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                String firstName = profileFirstName.Text;
                String lastName = profileLastName.Text;
                String email = profileEmail.Text;
                String phone = profilePhone.Text;
                String password = profilePassword.Text;
                String role = roleComboBox.SelectedItem.ToString();

                if (firstName == "" || lastName == "" || email == "" ||
                    phone == "" || password == "" || role == "")
                {
                    MessageBox.Show("Регистрация не может быть завершена", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                database.OpenConnection();

                string query = $"INSERT INTO member ( first_name, last_name, email, password, phone, role_id )" +
                               $" VALUES ( N'{firstName}', N'{lastName}', N'{email}', N'{encoder.Encode(password)}'," +
                               $" N'{phone}', (SELECT role_id FROM member_role WHERE role_name = N'{role}') )";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Успешная регистрация", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не удается завершить регистрацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void InitRoles()
        {
            try
            {
                database.OpenConnection();

                string query = $"SELECT role_name FROM member_role";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String role = reader["role_name"].ToString();
                        roleComboBox.Items.Add(role);
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
