using Library.SharedForms;
using Library.UserForms;
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
using static Library.UserForms.Dashboard;

namespace Library.StaffForms
{
    public partial class Dashboard : Form
    {
        Database database = new Database();

        public Dashboard()
        {
            InitializeComponent();
            searchComboBox.SelectedItem = searchComboBox.Items[0];

            RenderMemberList();
            RenderBooksList();
            RenderAuthorsList();
            RenderSubjectList();
            RenderProfile();
        }

        private void UpdateMembersButton_Click(object sender, EventArgs e)
        {
            RenderMemberList();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            using (RegisterForm form = new RegisterForm())
            {
                form.ShowDialog();
            }

            RenderMemberList();
        }

        private void DeleteMemberButton_Click(object sender, EventArgs e)
        {
            if (membersList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (membersList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите только одного читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String id = membersList.SelectedItems[0].SubItems[0].Text.ToString();
            DeleteMember(id);
            RenderMemberList();
        }

        private void DeleteMember(String memberId)
        {
            try
            {
                database.OpenConnection();

                string query = $"DELETE FROM member WHERE member_id = {memberId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                if (e.Message.Contains("Member has active loans"))
                {
                    MessageBox.Show("Пользователь не вернул книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void RenderMemberList()
        {
            membersList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = "SELECT * FROM member M" +
                               " INNER JOIN member_role R ON R.role_id = M.role_id" +
                               " WHERE R.role_name = N'USER'";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["member_id"].ToString();
                        String name = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                        String email = reader["email"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(name);
                        item.SubItems.Add(email);

                        membersList.Items.Add(item);
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

        private void RenderProfile()
        {
            try
            {
                database.OpenConnection();

                String email = MemberInfo.email;

                string query = $"SELECT * FROM member WHERE email = N'{email}'";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    profileFirstName.Text = reader["first_name"].ToString();
                    profileLastName.Text = reader["last_name"].ToString();
                    profileEmail.Text = email;
                    profilePhone.Text = reader["phone"].ToString();
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm form = new ChangePasswordForm())
            {
                form.ShowDialog();
            }
        }

        private void MembersList_DoubleClick(object sender, EventArgs e)
        {
            if (membersList.SelectedItems.Count == 1)
            {
                String memberId = membersList.SelectedItems[0].Text;

                using (MemberForm form = new MemberForm(memberId))
                {
                    form.ShowDialog();
                }
            }

            RenderMemberList();
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
            string searchString = searchTextBox.Text.ToString().Trim();
            string searchCriterion = searchComboBox.SelectedItem.ToString().Trim();

            string query = "";

            if (searchCriterion == "название")
            {
                query = $"EXEC get_books_by_title N'{searchString}'";
            }
            else if (searchCriterion == "автор")
            {
                query = $"EXEC get_books_by_author N'{searchString}'";
            }
            else if (searchCriterion == "предмет")
            {
                query = $"EXEC get_books_by_subject N'{searchString}'";
            }
            else
            {
                return;
            }

            try
            {
                booksList.Items.Clear();

                database.OpenConnection();

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RenderBooksList();
        }

        private void BooksList_DoubleClick(object sender, EventArgs e)
        {
            if (booksList.SelectedItems.Count == 1)
            {
                String bookId = booksList.SelectedItems[0].SubItems[0].Text;
                String bookTitle = booksList.SelectedItems[0].SubItems[1].Text;
                String date = booksList.SelectedItems[0].SubItems[4].Text;

                using (BookForm form = new BookForm(bookId, bookTitle, date))
                {
                    form.ShowDialog();
                }

                RenderBooksList();
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            using (AddBookForm form = new AddBookForm())
            {
                form.ShowDialog();
            }

            RenderBooksList();
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            using (AddAuthorForm form = new AddAuthorForm())
            {
                form.ShowDialog();
            }

            RenderAuthorsList();
        }

        private void RenderAuthorsList()
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

        private void SearchAuthorsButton_Click(object sender, EventArgs e)
        {
            RenderAuthorsList();
        }

        private void AuthorsList_DoubleClick(object sender, EventArgs e)
        {
            if (authorsList.SelectedItems.Count == 1)
            {
                String authorId = authorsList.SelectedItems[0].SubItems[0].Text;
                String firstName = authorsList.SelectedItems[0].SubItems[1].Text;
                String lastName = authorsList.SelectedItems[0].SubItems[2].Text;

                using (AuthorForm form = new AuthorForm(authorId, firstName, lastName))
                {
                    form.ShowDialog();
                }
            }

            RenderAuthorsList();
            RenderBooksList();
        }

        private void SearchSubjectsButton_Click(object sender, EventArgs e)
        {
            RenderSubjectList();
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            using (AddSubjectForm form = new AddSubjectForm())
            {
                form.ShowDialog();
            }

            RenderSubjectList();
            RenderBooksList();
        }

        private void RenderSubjectList()
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

        private void SubjectsList_DoubleClick(object sender, EventArgs e)
        {
            if (subjectsList.SelectedItems.Count == 1)
            {
                String subjectId = subjectsList.SelectedItems[0].SubItems[0].Text;
                String subjectName = subjectsList.SelectedItems[0].SubItems[1].Text;

                using (SubjectForm form = new SubjectForm(subjectId, subjectName))
                {
                    form.ShowDialog();
                }
            }

            RenderSubjectList();
            RenderBooksList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void authorSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            MemberInfo.memberId = "";
            MemberInfo.email = "";
            MemberInfo.role = "";

            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
