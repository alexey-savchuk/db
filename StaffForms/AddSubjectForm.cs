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

namespace Library.StaffForms
{
    public partial class AddSubjectForm : Form
    {
        Database database = new Database();

        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String subject = subjectNameTextBox.Text;

            try
            {
                database.OpenConnection();

                string query = $"INSERT INTO subject ( subject_name ) VALUES ( N'{subject}' )";

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
