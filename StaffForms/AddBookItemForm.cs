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
    public partial class AddBookItemForm : Form
    {
        Database database = new Database();
        String bookId = "";
        String selectedStatusId = "";
     
        public AddBookItemForm(String bookId)
        {
            InitializeComponent();
            this.bookId = bookId;

            RenderStatusList();
        }

        private void SelectStatusButton_Click(object sender, EventArgs e)
        {
            if (statusList.SelectedItems.Count == 1)
            {
                selectedStatusId = statusList.SelectedItems[0].SubItems[0].Text;
                statusTextBox.Text = statusList.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void RenderStatusList()
        {
            statusList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = "SELECT * FROM item_status";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["status_id"].ToString();
                        String status = reader["status_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(status);

                        statusList.Items.Add(item);
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

        private void AddBookItemButton_Click(object sender, EventArgs e)
        {
            database.OpenConnection();

            try
            {
                String barcode = barcodeTextBox.Text;
                String shelfMark = shelfMarkTextBox.Text;

                string query = $"INSERT INTO book_item ( barcode, shelf_mark, book_id, status_id )" +
                               $" VALUES ( N'{barcode}', N'{shelfMark}', {bookId}, {selectedStatusId} )";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ошибка", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
