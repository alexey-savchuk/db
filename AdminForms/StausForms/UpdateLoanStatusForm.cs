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
    public partial class UpdateLoanStatusForm : Form
    {
        Database database = new Database();
        String statusId = "";

        public UpdateLoanStatusForm(String statusId, String statusName)
        {
            InitializeComponent();
            this.statusId = statusId;
            statusNameTextBox.Text = statusName;
        }

        private void UpdateStatus_Click(object sender, EventArgs e)
        {
            String statusName = statusNameTextBox.Text;
            if (statusName == "")
            {
                MessageBox.Show("Статус не может быть обновлен", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                database.OpenConnection();

                string query = $"UPDATE loan_status" +
                               $" SET status_name = N'{statusName}'" +
                               $" WHERE status_id = {statusId}";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Статус обновлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Статус не может быть обновлен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
