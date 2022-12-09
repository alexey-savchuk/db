using Library.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.StaffForms
{
    public partial class AddBookForm : Form
    {
        Database database = new Database();

        List<String> selectedAuthorsIds = new List<String>(){};
        String selectedSubjectId = "";

        public AddBookForm()
        {
            InitializeComponent();

            RenderAutorsList();
            RenderSubjectsList();
        }

        private void AddButton_Click(object sender, EventArgs e)
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
                    String date = dateTextBox.Text.Trim();

                    cmd.CommandText = $"INSERT INTO book ( title, publication_date, subject_id )" +
                                      $" VALUES ( N'{title}', '{date}', {selectedSubjectId} )";
                    
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = $"SELECT MAX(book_id) FROM book";
                string bookId = cmd.ExecuteScalar().ToString();

                // authors
                {
                    foreach (String authorId in selectedAuthorsIds)
                    {
                        cmd.CommandText = $"INSERT INTO book_author ( book_id, author_id )" +
                                          $" VALUES ( {bookId}, {authorId} )";

                        cmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();

                MessageBox.Show("Книга была добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch
            {
                transaction.Rollback();

                MessageBox.Show("Не удалось добавить книгу", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void SearchAuthorsButton_Click(object sender, EventArgs e)
        {
            RenderAutorsList();
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
    }
}
