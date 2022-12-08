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

namespace Library.AdminForms.StausForms
{
    public partial class AddLoanStatusForm : Form
    {
        Database database = new Database();

        public AddLoanStatusForm()
        {
            InitializeComponent();
        }

        private void AddStatus_Click(object sender, EventArgs e)
        {
            String statusName = statusNameTextBox.Text;
            if (statusName == "")
            {
                MessageBox.Show("Статус не может быть добавлен", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                database.OpenConnection();

                string query = $"INSERT INTO loan_status ( status_name )" +
                               $" VALUES ( N'{statusName}' )";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Статус добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Статус не может быть добавлен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
