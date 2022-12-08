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
    public partial class LoanForm : Form
    {
        Database database = new Database();

        public LoanForm(String loanId)
        {
            InitializeComponent();

            database.OpenConnection();

            string query = $"SELECT * FROM member_and_loan WHERE loan_id = {loanId}";
            SqlCommand cmd = new SqlCommand(query, database.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            String bookId = reader["book_id"].ToString();
            String title = "";
            String authors = "";
            String subject = "";
            String date = reader["loan_date"].ToString().Split(' ')[0];
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

            loanBook.Text = title;
            loanAuthors.Text = authors;
            loanSubject.Text = subject;
            loanDate.Text = date;
            loanStatus.Text = status;

            database.CloseConnection();
        }
    }
}
