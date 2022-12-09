using Library.SharedForms;
using Library.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.UserForms
{
    public partial class Dashboard : Form
    {
        private Database database = new Database();
        private List<BookRecord> foundBooks = new List<BookRecord>();

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


        public Dashboard()
        {
            InitializeComponent();
            searchComboBox.SelectedItem = searchComboBox.Items[0];
            RenderReservationsList();
            RenderLoansList();
            RenderProfile();
        }

        private void SearchButton_Click(object sender, EventArgs e)
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
                booksListView.Items.Clear();
                foundBooks.Clear();

                database.OpenConnection();

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                List<BookRecord> books = new List<BookRecord>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["book_id"].ToString();
                        string title = reader["title"].ToString();
                        string author = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
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

                foundBooks = books;

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

                    booksListView.Items.Add(item);
                }
            }
            catch
            {
                database.CloseConnection();
            }
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали книгу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (booksListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите только одну книгу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String id = booksListView.SelectedItems[0].SubItems[0].Text.ToString();
            ReserveBook(id);

            MessageBox.Show($"Вы выбрали книгу с id = {id}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RenderReservationsList();
        }

        private void ReserveBook(String bookId)
        {
            database.OpenConnection();

            try
            {
                string query = $"EXEC create_reservation @member_id={MemberInfo.memberId}, @book_id={bookId}";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void UpdateReservationsButton_Click(object sender, EventArgs e)
        {
            RenderReservationsList();
        }

        private void CancelReservationButton_Click(object sender, EventArgs e)
        {
            if (reservationsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали заявку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (reservationsList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите только одну заявку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String id = reservationsList.SelectedItems[0].SubItems[0].Text.ToString();
            CancelReservation(id);
            RenderReservationsList();

            MessageBox.Show($"Вы выбрали заявку с id = {id}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RenderReservationsList()
        {
            reservationsList.Items.Clear();

            String email = MemberInfo.email;

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM member_and_reservation WHERE email = N'{email}'";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["reservation_id"].ToString();
                        String book = reader["title"].ToString();
                        String date = reader["reservation_date"].ToString().Split(' ')[0];
                        String status = reader["status_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(book);
                        item.SubItems.Add(date);
                        item.SubItems.Add(status);

                        reservationsList.Items.Add(item);
                    }
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
            }
        }

        private void CancelReservation(String reservationId)
        {
            try
            {
                database.OpenConnection();

                String query = "SELECT status_id FROM reservation_status WHERE status_name = N'CANCELED'";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                String statusId = cmd.ExecuteScalar().ToString();

                query = $"UPDATE reservation SET status_id = {statusId} WHERE reservation_id = {reservationId}";
                cmd = new SqlCommand(query, database.GetConnection());

                cmd.ExecuteNonQuery();

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
            }
        }

        private void UpdateLoanList_Click(object sender, EventArgs e)
        {
            RenderLoansList();
        }

        private void RenderLoansList()
        {
            loansList.Items.Clear();

            String email = MemberInfo.email;

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM member_and_loan WHERE email = N'{email}'";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String id = reader["loan_id"].ToString();
                        String book = reader["title"].ToString();
                        String date = reader["loan_date"].ToString().Split(' ')[0];
                        String status = reader["status_name"].ToString();

                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(book);
                        item.SubItems.Add(date);
                        item.SubItems.Add(status);

                        loansList.Items.Add(item);
                    }
                }

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
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
            using(ChangePasswordForm form = new ChangePasswordForm())
            {
                form.ShowDialog();
            }
        }

        private void ReservationsList_DoubleClick(object sender, EventArgs e)
        {
            if (reservationsList.SelectedItems.Count == 1)
            {
                String reservationId = reservationsList.SelectedItems[0].Text;

                using (ReservationForm form = new ReservationForm(reservationId))
                {
                    form.ShowDialog();
                }
            }
        }

        private void LoanList_DoubleClick(object sender, EventArgs e)
        {
            if (loansList.SelectedItems.Count == 1)
            {
                String loanId = loansList.SelectedItems[0].Text;

                using (LoanForm form = new LoanForm(loanId))
                {
                    form.ShowDialog();
                }
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
    }
}
