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

namespace Library.UserForms
{
    public partial class ReservationForm : Form
    {
        Database database = new Database();

        public ReservationForm(String reservationId)
        {
            InitializeComponent();

            database.OpenConnection();

            string query = $"SELECT * FROM member_and_reservation WHERE reservation_id = {reservationId}";
            SqlCommand cmd = new SqlCommand(query, database.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            String bookId = reader["book_id"].ToString();
            String title = "";
            String authors = "";
            String subject = "";
            String date = reader["reservation_date"].ToString().Split(' ')[0];
            String status = reader["status_name"].ToString();

            reader.Close();

            query = $"SELECT * FROM book_and_author WHERE book_id = {bookId}";
            cmd = new SqlCommand(query, database.GetConnection());

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    title = reader["title"].ToString();
                    authors += reader["first_name"] + " " + reader["last_name"] + ", ";
                    subject = reader["subject_name"].ToString();
                }
            }

            reservationBook.Text = title;
            reservationAuthors.Text = authors;
            reservationSubject.Text = subject;
            reservationDate.Text = date;
            reservationStatus.Text = status;

            database.CloseConnection();
        }
    }
}
