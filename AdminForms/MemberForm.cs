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

namespace Library.AdminForms
{
    public partial class MemberForm : Form
    {
        Database database = new Database();
        String memberId = "";

        public MemberForm(String memberId)
        {
            InitializeComponent();
            this.memberId = memberId;

            RenderProfile();
            RenderReservationsList();
            RenderLoansList();
        }

        private void RenderProfile()
        {
            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM member WHERE member_id = {memberId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                profileFirstName.Text = reader["first_name"].ToString();
                profileLastName.Text = reader["last_name"].ToString();
                profileEmail.Text = reader["email"].ToString();
                profilePhone.Text = reader["phone"].ToString();

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }

        private void ChangeProfileButton_Click(object sender, EventArgs e)
        {
            String firstName = profileFirstName.Text;
            String lastName = profileLastName.Text;
            String email = profileEmail.Text;
            String phone = profilePhone.Text;

            try
            {
                database.OpenConnection();

                string query = $"UPDATE member SET first_name = N'{firstName}', last_name = N'{lastName}'," +
                               $" email = N'{email}', phone = N'{phone}' WHERE member_id = {memberId}";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.ExecuteNonQuery();

                RenderProfile();
                MessageBox.Show("Успех", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                database.CloseConnection();
                throw;
            }
        }

        private void RenderReservationsList()
        {
            reservationsList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM member_and_reservation WHERE member_id = {memberId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                SqlDataReader reader = cmd.ExecuteReader();

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

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
            }
        }

        private void RenderLoansList()
        {
            loansList.Items.Clear();

            try
            {
                database.OpenConnection();

                string query = $"SELECT * FROM member_and_loan WHERE member_id = {memberId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                SqlDataReader reader = cmd.ExecuteReader();

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

                database.CloseConnection();
            }
            catch
            {
                database.CloseConnection();
                throw;
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

                RenderReservationsList();
            }
        }

        private void LoansList_DoubleClick(object sender, EventArgs e)
        {
            if (loansList.SelectedItems.Count == 1)
            {
                String loanId = loansList.SelectedItems[0].Text;

                using (LoanForm form = new LoanForm(loanId))
                {
                    form.ShowDialog();
                }

                RenderLoansList();
            }
        }

        private void UpdateReservationsButton_Click(object sender, EventArgs e)
        {
            RenderReservationsList();
        }

        private void UpdateLoansButton_Click(object sender, EventArgs e)
        {
            RenderLoansList();
        }

        private void CreateLoanButton_Click(object sender, EventArgs e)
        {
            if (reservationsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (reservationsList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите только одного читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String id = reservationsList.SelectedItems[0].SubItems[0].Text.ToString();
            CreateLoan(id);
            RenderLoansList();

            MessageBox.Show($"Вы выбрали заявку с id = {id}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateLoan(String reservationId)
        {
            try
            {
                database.OpenConnection();

                string query = $"EXEC create_loan_with_reservation {reservationId}";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Успех", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                database.CloseConnection();
                throw;
            }
        }
    }
}
