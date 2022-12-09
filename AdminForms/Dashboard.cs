using Library.AdminForms.StausForms;
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

namespace Library.AdminForms
{
    public partial class Dashboard : Form
    {
        Database database = new Database();

        public Dashboard()
        {
            InitializeComponent();
            searchComboBox.SelectedItem = searchComboBox.Items[0];

            InitRoles();
            roleComboBox.SelectedItem = roleComboBox.Items[0];
            RenderMemberList();

            RenderBooksList();
            RenderAuthorsList();
            RenderSubjectList();
            RenderProfile();

            RenderReservationStatusList();
            RenderLoanStatusList();
            RenderItemStatusList();
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

            MessageBox.Show($"Вы выбрали заявку с id = {id}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteMember(String memberId)
        {
            try
            {
                database.OpenConnection();

                string query = $"DELETE FROM member WHERE member_id = {memberId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                cmd.ExecuteNonQuery();

                database.CloseConnection();
            }
            catch
            {

                database.CloseConnection();
                throw;
            }
        }

        private void InitRoles()
        {
            try
            {
                database.OpenConnection();

                string query = $"SELECT role_name FROM member_role";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String role = reader["role_name"].ToString();
                        roleComboBox.Items.Add(role);
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

        private void RenderMemberList()
        {
            membersList.Items.Clear();

            try
            {
                database.OpenConnection();

                String role = roleComboBox.SelectedItem.ToString();

                string query = $"SELECT * FROM member M" +
                               $" INNER JOIN member_role R ON R.role_id = M.role_id" +
                               $" WHERE M.member_id <> {MemberInfo.memberId} AND R.role_name = N'{role}'";

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

            public BookRecord(String id, String title, List<String> authors, String subject, String date)
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

        private void AddReservationStatus_Click(object sender, EventArgs e)
        {
            using (AddReservationStatusForm form = new AddReservationStatusForm())
            {
                form.ShowDialog();
            }

            RenderReservationStatusList();
        }

        private void AddLoanStatus_Click(object sender, EventArgs e)
        {
            using (AddLoanStatusForm form = new AddLoanStatusForm())
            {
                form.ShowDialog();
            }

            RenderLoanStatusList();
        }

        private void AddItemStatus_Click(object sender, EventArgs e)
        {
            using (AddItemStatusForm form = new AddItemStatusForm())
            {
                form.ShowDialog();
            }

            RenderItemStatusList();
        }

        private void RenderReservationStatusList()
        {
            reservationStatusList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = $"SELECT status_id, status_name FROM reservation_status";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["status_id"].ToString();
                        String status = reader["status_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(status);

                        reservationStatusList.Items.Add(item);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удается отобразить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void RenderLoanStatusList()
        {
            loanStatusList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = $"SELECT status_id, status_name FROM loan_status";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["status_id"].ToString();
                        String status = reader["status_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(status);

                        loanStatusList.Items.Add(item);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удается отобразить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void RenderItemStatusList()
        {
            itemStatusList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = $"SELECT status_id, status_name FROM item_status";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["status_id"].ToString();
                        String status = reader["status_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(status);

                        itemStatusList.Items.Add(item);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удается отобразить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void DeleteReservationStatus_Click(object sender, EventArgs e)
        {
            if (reservationStatusList.SelectedItems.Count > 0)
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    foreach (ListViewItem item in reservationStatusList.SelectedItems)
                    {
                        String id = item.SubItems[0].Text;

                        cmd.CommandText = $"DELETE FROM reservation_status WHERE status_id = {id}";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    RenderReservationStatusList();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Не удается завершить удаление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    database.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Выберите статусы для удаления", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteLoanStatus_Click(object sender, EventArgs e)
        {
            if (loanStatusList.SelectedItems.Count > 0)
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    foreach (ListViewItem item in loanStatusList.SelectedItems)
                    {
                        String id = item.SubItems[0].Text;

                        cmd.CommandText = $"DELETE FROM loan_status WHERE status_id = {id}";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    RenderLoanStatusList();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Не удается завершить удаление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    database.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Выберите статусы для удаления", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteItemStatus_Click(object sender, EventArgs e)
        {
            if (itemStatusList.SelectedItems.Count > 0)
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    foreach (ListViewItem item in itemStatusList.SelectedItems)
                    {
                        String id = item.SubItems[0].Text;

                        cmd.CommandText = $"DELETE FROM item_status WHERE status_id = {id}";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    RenderItemStatusList();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Не удается завершить удаление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    database.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Выберите статусы для удаления", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReservationStatusList_DoubleClick(object sender, EventArgs e)
        {
            if (reservationStatusList.SelectedItems.Count == 1)
            {
                String id = reservationStatusList.SelectedItems[0].SubItems[0].Text;
                String status = reservationStatusList.SelectedItems[0].SubItems[1].Text;

                using (UpdateItemStatusForm form = new UpdateItemStatusForm(id, status))
                {
                    form.ShowDialog();
                }

                RenderReservationStatusList();
            }
        }

        private void LoanStatusList_DoubleClick(object sender, EventArgs e)
        {
            if (loanStatusList.SelectedItems.Count == 1)
            {
                String id = loanStatusList.SelectedItems[0].SubItems[0].Text;
                String status = loanStatusList.SelectedItems[0].SubItems[1].Text;

                using (UpdateItemStatusForm form = new UpdateItemStatusForm(id, status))
                {
                    form.ShowDialog();
                }

                RenderLoanStatusList();
            }
        }

        private void ItemStatus_DoubleClick(object sender, EventArgs e)
        {
            if (itemStatusList.SelectedItems.Count == 1)
            {
                String id = itemStatusList.SelectedItems[0].SubItems[0].Text;
                String status = itemStatusList.SelectedItems[0].SubItems[1].Text;

                using (UpdateItemStatusForm form = new UpdateItemStatusForm(id, status))
                {
                    form.ShowDialog();
                }

                RenderItemStatusList();
            }
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

        private void DeleteBooks_Click(object sender, EventArgs e)
        {
            if (booksList.SelectedItems.Count > 0)
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    foreach (ListViewItem item in booksList.SelectedItems)
                    {
                        String id = item.SubItems[0].Text;

                        cmd.CommandText = $"DELETE FROM book WHERE book_id = {id}";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    RenderBooksList();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Не удается завершить удаление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    database.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Выберите книги для удаления", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteAuthors_Click(object sender, EventArgs e)
        {
            if (authorsList.SelectedItems.Count > 0)
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    foreach (ListViewItem item in authorsList.SelectedItems)
                    {
                        String id = item.SubItems[0].Text;

                        cmd.CommandText = $"DELETE FROM author WHERE author_id = {id}";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    RenderAuthorsList();
                    RenderBooksList();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Не удается завершить удаление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    database.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Выберите авторов для удаления", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteSubjects_Click(object sender, EventArgs e)
        {
            if (subjectsList.SelectedItems.Count > 0)
            {
                database.OpenConnection();

                SqlConnection connection = database.GetConnection();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = transaction;

                    foreach (ListViewItem item in subjectsList.SelectedItems)
                    {
                        String id = item.SubItems[0].Text;

                        cmd.CommandText = $"DELETE FROM subject WHERE subject_id = {id}";
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    RenderSubjectList();
                    RenderBooksList();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Не удается завершить удаление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    database.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Выберите предметы для удаления", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            String firstName = profileFirstName.Text;
            String lastName = profileLastName.Text;
            String email = profileEmail.Text;
            String phone = profilePhone.Text;

            try
            {
                database.OpenConnection();

                string query = $"UPDATE member SET first_name = N'{firstName}', last_name = N'{lastName}'," +
                               $" email = N'{email}', phone = N'{phone}' WHERE member_id = {MemberInfo.memberId}";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MemberInfo.email = email;

                RenderProfile();
                MessageBox.Show("Данные профиля обновлены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось обновить данные профиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
