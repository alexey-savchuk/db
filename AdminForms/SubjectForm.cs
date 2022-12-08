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
    public partial class SubjectForm : Form
    {
        Database database = new Database();
        String subjectId = "";

        public SubjectForm(String subjectId, String subjectName)
        {
            InitializeComponent();
            this.subjectId = subjectId;

            subjectNameTextBox.Text = subjectName;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String subject = subjectNameTextBox.Text;

            try
            {
                database.OpenConnection();

                string query = $"UPDATE subject SET subject_name = N'{subject}'" +
                               $" WHERE subject_id = {subjectId}";

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
