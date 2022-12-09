using Library.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.AdminForms
{
    public partial class BookForm : Form
    {
        Database database = new Database();
        String bookId = "";

        List<String> selectedAuthorsIds = new List<String>(){};
        String selectedSubjectId = "";

        public BookForm(String bookId, String bookTitle, String date)
        {
            InitializeComponent();
            this.bookId = bookId;

            titleTextBox.Text = bookTitle;
            dateTextBox.Text = date;

            InitAuthorsList();
            InitSubjectsList();

            RenderAutorsList();
            RenderSubjectsList();
            RenderBookItemsList();
        }

        private void RenderBookItemsList()
        {
            bookItemsList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM book_item WHERE book_id = {bookId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["book_item_id"].ToString();
                        String barcode = reader["barcode"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(barcode);

                        bookItemsList.Items.Add(item);
                    }
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;

            try
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection();
                transaction = connection.BeginTransaction();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.Transaction = transaction;

                // book
                {
                    String title = titleTextBox.Text.Trim();

                    cmd.CommandText = $"UPDATE book SET title = N'{title}', subject_id = {selectedSubjectId}" +
                                      $" WHERE book_id = {bookId}";
                    cmd.ExecuteNonQuery();
                }

                // authors
                {
                    cmd.CommandText = $"DELETE FROM book_author WHERE book_id = {bookId}";
                    cmd.ExecuteNonQuery();

                    foreach (String authorId in selectedAuthorsIds)
                    {
                        cmd.CommandText = $"INSERT INTO book_author ( book_id, author_id )" +
                                          $" VALUES ( {bookId}, {authorId} )";

                        cmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();

                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.CloseConnection();
            }
            catch
            {
                transaction.Rollback();

                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                database.CloseConnection();
                throw;
            }
        }

        private void SearchAuthorsButton_Click(object sender, EventArgs e)
        {
            RenderAutorsList();
        }

        private void InitAuthorsList()
        {
            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM book_and_author WHERE book_id = {bookId}";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["author_id"].ToString();
                        String firstName = reader["first_name"].ToString();
                        String lastName = reader["last_name"].ToString();

                        selectedAuthorsIds.Add(id);
                        authorsTextBox.Text += firstName + " " + lastName + ", ";
                    }
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }

        private void RenderAutorsList()
        {
            authorsList.Items.Clear();

            String searchText = authorSearch.Text.Trim().ToLower();

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM author" +
                               $" WHERE LOWER(first_name) + ' ' + LOWER(last_name) LIKE N'%{searchText}%'";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["author_id"].ToString();
                        String firstName = reader["first_name"].ToString();
                        String lastName = reader["last_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(firstName);
                        item.SubItems.Add(lastName);

                        authorsList.Items.Add(item);
                    }
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }

        private void SearchSubjectsButton_Click(object sender, EventArgs e)
        {
            RenderSubjectsList();
        }

        private void InitSubjectsList()
        {
            try
            {
                database.OpenConnection();

                string query = $"SELECT DISTINCT subject_id, subject_name FROM book_and_author WHERE book_id = {bookId}";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["subject_id"].ToString();
                        String subject = reader["subject_name"].ToString();

                        selectedSubjectId= id;
                        subjectTextBox.Text = subject;
                    }
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }

        private void RenderSubjectsList()
        {
            subjectsList.Items.Clear();

            String searchText = subjectSearch.Text.Trim().ToLower();

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM subject" +
                               $" WHERE LOWER(subject_name) LIKE N'%{searchText}%'";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["subject_id"].ToString();
                        String subject = reader["subject_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(subject);

                        subjectsList.Items.Add(item);
                    }
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }

        private void SelectAuthorsButton_Click(object sender, EventArgs e)
        {
            if (authorsList.SelectedItems.Count > 0)
            {
                selectedAuthorsIds.Clear();
                authorsTextBox.Text = "";

                foreach (ListViewItem item in authorsList.SelectedItems)
                {
                    String authorId = item.SubItems[0].Text;
                    String firstName = item.SubItems[1].Text;
                    String lastName = item.SubItems[2].Text;

                    selectedAuthorsIds.Add(authorId);

                    authorsTextBox.Text += firstName + " " + lastName + ", ";
                }
            }
            else
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectSubjectsButton_Click(object sender, EventArgs e)
        {
            if (subjectsList.SelectedItems.Count == 1)
            {

                subjectTextBox.Text = "";

                ListViewItem item = subjectsList.SelectedItems[0];

                String subjectId = item.SubItems[0].Text;
                String subjectName = item.SubItems[1].Text;

                selectedSubjectId = subjectId;
                subjectTextBox.Text = subjectName;
            }
            else
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBookItems_Click(object sender, EventArgs e)
        {
            RenderBookItemsList();
        }

        private void DeleteBookItemButton_Click(object sender, EventArgs e)
        {
            if (bookItemsList.SelectedItems.Count > 1)
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection(); 
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    foreach (ListViewItem item in bookItemsList.SelectedItems)
                    {
                        String itemId = item.SubItems[0].Text;

                        cmd.CommandText = $"DELETE FROM book_item WHERE book_item_id = {itemId}";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    database.CloseConnection();
                }

                RenderBookItemsList();
            }
        }

        private void BookItemsList_DoubleClick(object sender, EventArgs e)
        {
            if (bookItemsList.SelectedItems.Count == 1)
            {
                String bookItemId = bookItemsList.SelectedItems[0].SubItems[0].Text;

                using (BookItemForm form = new BookItemForm(bookItemId))
                {
                    form.ShowDialog();
                }

                RenderBookItemsList();
            }
        }

        private void AddBookItemButton_Click(object sender, EventArgs e)
        {
            using (AddBookItemForm form = new AddBookItemForm(bookId))
            {
                form.ShowDialog();
            }

            RenderBookItemsList();
        }
    }
}
