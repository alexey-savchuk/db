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
        }

        private void SubmitRegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                String firstName = profileFirstName.Text;
                String lastName = profileLastName.Text;
                String email = profileEmail.Text;
                String phone = profilePhone.Text;
                String password = encoder.Encode(profilePassword.Text);

                database.OpenConnection();

                string query = $"INSERT INTO member ( first_name, last_name, email, password, phone, role_id )" +
                               $" VALUES ( N'{firstName}', N'{lastName}', N'{email}', N'{password}', N'{phone}'," +
                               $" (SELECT role_id FROM member_role WHERE role_name = 'USER') )";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Успех", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                database.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                database.CloseConnection();
                throw;
            }
        }
    }
}
