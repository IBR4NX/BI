using DataAccess.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataAccess.SqlServer
{
    public class SqlServerConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;
        public IDbConnection connection { get; set; }


        public SqlServerConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {

            connection = new SqlConnection(_connectionString);

            return connection;
        }
        public IDbConnection OpenConnection()
        {
            IDbConnection dbConnection = CreateConnection();
            dbConnection.Open();
            return dbConnection;
        }
   
    }
}