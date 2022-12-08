using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library.Utils
{
    internal class Database
    {
        SqlConnection connection = null;

        public Database()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
