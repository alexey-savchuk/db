using System.Data;
using System.Data.SqlClient;

namespace Library.Utils
{
    internal class Database
    {
        SqlConnection connection = null;

        public Database()
        {
            connection = new SqlConnection(@"Data Source=192.168.0.2\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=library;User ID=sa;Password=DrunkAdmin1!");
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
