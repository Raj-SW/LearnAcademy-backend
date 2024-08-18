using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace LearnAcademy.DAL
{
    public class DataAccessLayer : IDataAccessLayer
    {
        public SqlConnection connection;
        string connectionString;

        public DataAccessLayer()
        {
            connectionString = "Data Source=LAPTOP-4M1J5GRF;Inital Catalog=LearningAcademy; Integrated Security=true";
            connection = new SqlConnection(connectionString);
            OpenConnection();
        }
        public async Task OpenConnectionAsync()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                await connection.OpenAsync();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                //throw ex;
            }
        }
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
        }
        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
