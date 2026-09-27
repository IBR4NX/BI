using DataAccess.Factory;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace DataAccess.SqlServer
{
    public class SqlServerConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;
        public IDbConnection Connection { get; set; }

        public SqlServerConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
            Connection = new SqlConnection(_connectionString);
        }

        public IDbConnection CreateConnection()
        {
            Debug.WriteLine(Connection.State+"@@@@@@@@@@@@@@@@@@@@@@@@@@");
            if (Connection == null)
            {
                Connection = new SqlConnection(_connectionString);
            }
            else if (Connection.State == ConnectionState.Open)
                Connection.Close();

                return Connection;
        }

        public IDbConnection OpenConnection()
        {
           //using IDbConnection dbConnection = CreateConnection();
           // dbConnection.Open();
           // //if(dbConnection.State.Equals())

            return Connection;
        }
        public bool ConnectionOpened()
        {

            if (Connection.State == ConnectionState.Open)
                return true;
            try
            {
                Connection.Open();
                
                return true;
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e);
                //throw new Exception(e.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

    }
}