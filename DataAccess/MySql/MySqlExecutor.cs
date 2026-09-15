//using DataAccess.Factory;
//using System.Data;


//namespace DataAccess.MySql
//{
//    public class MySqlExecutor : IDbExecutorFactory
//    {
//        private readonly IDbConnectionFactory _connectionFactory;

//        public MySqlExecutor(IDbConnectionFactory connectionFactory)
//        {
//            _connectionFactory = connectionFactory;
//        }

//        public IDataReader ExecuteReader(string commandText, params IDbDataParameter[] parameters)
//        {
//            IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            IDbCommand command = connection.CreateCommand();

//            command.CommandText = commandText;

//            foreach (IDbDataParameter parameter in parameters)
//            {
//                command.Parameters.Add(parameter);
//            }

//            return command.ExecuteReader(CommandBehavior.CloseConnection);
//        }

//        public object? ExecuteScalar(string commandText, params IDbDataParameter[] parameters)
//        {
//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = commandText;

//            foreach (IDbDataParameter parameter in parameters)
//            {
//                command.Parameters.Add(parameter);
//            }

//            return command.ExecuteScalar();
//        }

//        public int ExecuteNonQuery(string commandText, params IDbDataParameter[] parameters)
//        {
//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = commandText;

//            foreach (IDbDataParameter parameter in parameters)
//            {
//                command.Parameters.Add(parameter);
//            }

//            return command.ExecuteNonQuery();
//        }
//    }
//}