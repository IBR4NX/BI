using DataAccess.Factory;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess.SqlServer
{
    public class SqlServerExecutorFactory : IDbExecutorFactory
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public SqlServerExecutorFactory(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IDataReader ExecuteReader(string commandText, params IDbDataParameter[] parameters)
        {
            IDbConnection connection = _connectionFactory.CreateConnection();

            connection.Open();

            IDbCommand command = connection.CreateCommand();

            command.CommandText = commandText;

            foreach (IDbDataParameter parameter in parameters)
            { 
                command.Parameters.Add(parameter);
            }

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public object? ExecuteScalar(string commandText, params IDbDataParameter[] parameters)
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();

            connection.Open();

            using IDbCommand command = connection.CreateCommand();

            command.CommandText = commandText;

            foreach (IDbDataParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command.ExecuteScalar();
        }
        public DataTable ExecuteQuery(string commandText, params IDbDataParameter[] parameters)
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();

            connection.Open();

             SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandText, (SqlConnection)connection);


            foreach (IDbDataParameter parameter in parameters)
            {
                sqlDataAdapter.SelectCommand.Parameters.Add(parameter);
            }



            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }

        public int ExecuteNonQuery(string commandText, params IDbDataParameter[] parameters)
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();

            connection.Open();

            using IDbCommand command = connection.CreateCommand();

            command.CommandText = commandText;

            foreach (IDbDataParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command.ExecuteNonQuery();
        }
    }
}