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
    public partial class AuthorForm : Form
    {
        Database database = new Database();
        String authorId = "";

        public AuthorForm(String authorId, String firstName, String lastName)
        {
            InitializeComponent();
            this.authorId = authorId;

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;

            try
            {
                database.OpenConnection();

                string query = $"UPDATE author SET first_name = N'{firstName}', last_name = N'{lastName}'" +
                               $" WHERE author_id = {authorId}";

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
