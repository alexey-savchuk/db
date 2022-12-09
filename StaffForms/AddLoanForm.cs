using Library.Utils;
using System;
using System.Collections;
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
    public partial class AddLoanForm : Form
    {
        Database database = new Database();
        String memberId = "";

        public AddLoanForm(String memberId)
        {
            InitializeComponent();
            this.memberId = memberId;

            RenderBooksList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (booksList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Книга не выбрана", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (booksList.SelectedItems.Count > 1)
            {
                MessageBox.Show("Выберите только одну книгу", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string bookId = booksList.SelectedItems[0].SubItems[0].Text;

            try
            {
                database.OpenConnection();

                string query = $"EXEC create_loan @member_id={memberId}, @book_id={bookId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("No book item to reserve"))
                {
                    MessageBox.Show("Нет доступных экземпляров книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Loans limit reached"))
                {
                    MessageBox.Show("Достигнут лимит записей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                database.CloseConnection();
            }
        }


        internal class BookRecord
        {
            public String id;
            public String title { get; set; }
            public List<String> authors { get; set; } = new List<string>();
            public String subject { get; set; }
            public String date { get; set; }

            public BookRecord(String id, String title, List<String> authors, String subject, string date)
            {
                this.id = id;
                this.title = title;
                this.authors = authors;
                this.subject = subject;
                this.date = date;
            }
        }

        private void RenderBooksList()
        {
            try
            {
                booksList.Items.Clear();

                database.OpenConnection();

                string query = $"EXEC get_books_by_title N''";

                List<BookRecord> books = new List<BookRecord>();

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["book_id"].ToString();
                        string title = reader["title"].ToString();

                        string author = Convert.ToString(reader["first_name"])
                            + " " + Convert.ToString(reader["last_name"]);

                        string subject = reader["subject_name"].ToString();
                        string date = reader["publication_date"].ToString();

                        date = date.Split(' ')[0].Split('.')[2];

                        bool isExists = false;
                        foreach (BookRecord book in books)
                        {
                            if (book.title == title)
                            {
                                isExists = true;
                                book.authors.Add(author);
                            }
                        }

                        if (!isExists)
                        {
                            books.Add(new BookRecord(id, title, new List<String>() { author }, subject, date));
                        }
                    }
                }

                foreach (BookRecord book in books)
                {
                    ListViewItem item = new ListViewItem(book.id);

                    item.SubItems.Add(book.title);

                    String authors = "";
                    foreach (String author in book.authors)
                    {
                        authors += author + ", ";
                    }

                    item.SubItems.Add(authors);
                    item.SubItems.Add(book.subject);
                    item.SubItems.Add(book.date);

                    booksList.Items.Add(item);
                }
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }
    }
}
