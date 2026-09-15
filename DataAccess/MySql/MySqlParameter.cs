//using DataAccess.Factory;
//using Microsoft.Data.SqlClient;
//using System.Data;

//namespace DataAccess.MySql
//{
//    public class MySqlParameter : IDbParameterFactory
//    {
//        public IDbDataParameter CreateParameter(string name, object? value)
//        {
//            return new SqlParameter(name, value ?? DBNull.Value);
//        }
//    }
//}