//using DataAccess.Factory;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Text;
//using MySqlConnector;


//namespace DataAccess.MySql
//{
//    public class MySqlConnectionFactory : IDbConnectionFactory
//    {
//        private readonly string _connectionString;


//        public MySqlConnectionFactory(string connectionString) => _connectionString = connectionString;

//        public IDbConnection CreateConnection()
//        {
//            return new MySqlConnection(_connectionString);
//        }
//    }
//}