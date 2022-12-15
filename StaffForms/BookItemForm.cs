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
    public partial class BookItemForm : Form
    {
        Database database = new Database();
        String bookItemId = "";
        String selectedStatusId = "";

        public BookItemForm(String bookItemId)
        {
            InitializeComponent();
            this.bookItemId = bookItemId;

            InitBookItem();
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

        private void InitBookItem()
        {
            database.OpenConnection();

            try
            {
                string query = $"SELECT * FROM book_item BI" +
                               $" JOIN item_status S ON S.status_id = BI.status_id" +
                               $" WHERE BI.book_item_id = {bookItemId}";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    String barcode = reader["barcode"].ToString();
                    String shelfMark = reader["shelf_mark"].ToString();
                    String statusId = reader["status_id"].ToString();
                    String statusName = reader["status_name"].ToString();

                    barcodeTextBox.Text = barcode;
                    shelfMarkTextBox.Text = shelfMark;
                    statusTextBox.Text = statusName;

                    selectedStatusId = statusId;
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

        private void UpdateBookItemButton_Click(object sender, EventArgs e)
        {
            database.OpenConnection();

            try
            {
                String barcode = barcodeTextBox.Text;
                String shelfMark = shelfMarkTextBox.Text;

                string query = $"UPDATE book_item SET barcode = N'{barcode}'," +
                               $" shelf_mark = N'{shelfMark}', status_id = {selectedStatusId}" +
                               $" WHERE book_item_id = {bookItemId}";

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

        private void statusList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shelfMarkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void barcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
