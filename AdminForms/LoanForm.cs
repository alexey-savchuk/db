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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.AdminForms
{
    public partial class LoanForm : Form
    {
        Database database = new Database();
        String loanId = "";
        String selectedStatusId = "";

        public LoanForm(String loanId)
        {
            InitializeComponent();
            this.loanId = loanId;

            InitLoan();
            RenderStatusList();
        }

        private void InitLoan()
        {
            database.OpenConnection();

            try
            {
                String bookId = "";
                String title = "";
                String authors = "";
                String subject = "";
                String barcode = "";
                String shelfMark = "";
                String date = "";
                String status = "";

                string query = $"SELECT * FROM member_and_loan WHERE loan_id = {loanId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    bookId = reader["book_id"].ToString();
                    date = reader["loan_date"].ToString().Split(' ')[0];
                    status = reader["status_name"].ToString();

                    selectedStatusId = reader["status_id"].ToString();
                }

                query = $"SELECT * FROM book_and_author WHERE book_id = {bookId}";
                cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        title = reader["title"].ToString();
                        authors += reader["first_name"] + " " + reader["last_name"] + ", ";
                        subject = reader["subject_name"].ToString();
                    }
                }

                query = $"SELECT * FROM book_item BI" +
                        $" JOIN loan L ON L.book_item_id = BI.book_item_id" +
                        $" WHERE loan_id = {loanId}";

                cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    barcode = reader["barcode"].ToString();
                    shelfMark = reader["shelf_mark"].ToString();
                }

                loanBook.Text = title;
                loanAuthors.Text = authors;
                loanSubject.Text = subject;
                loanBarcode.Text = barcode;
                loanShelfMark.Text = shelfMark;
                loanDate.Text = date;
                loanStatus.Text = status;
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

                string query = "SELECT * FROM loan_status";

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

        private void SelectStatusButton_Click(object sender, EventArgs e)
        {
            if (statusList.SelectedItems.Count == 1)
            {
                selectedStatusId = statusList.SelectedItems[0].SubItems[0].Text;
                loanStatus.Text = statusList.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void UpdateLoanButton_Click(object sender, EventArgs e)
        {
            database.OpenConnection();

            try
            {
                string query = $"UPDATE loan SET status_id = {selectedStatusId}" +
                               $" WHERE loan_id = {loanId}";

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
