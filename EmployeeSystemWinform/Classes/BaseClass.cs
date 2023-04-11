using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeSystemWinform.Classes
{
    public class BaseClass
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        private SqlConnection _connection;
        protected SqlCommand OpenConnection(string query)
        {
            _connection = new(_connectionString);
            _connection.Open();
            SqlCommand cmd = new(query, _connection);
            return cmd;
        } 
        protected void CloseConnection()
        {
            _connection.Close();
        }
    }
}
