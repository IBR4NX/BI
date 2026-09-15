using System;
using System.Collections.Generic;
using System.Text;
 using System.Data;

namespace DataAccess.Factory
{
    public interface IDbExecutorFactory
    {
        IDataReader ExecuteReader(string commandText, params IDbDataParameter[] parameters);

        object? ExecuteScalar(string commandText, params IDbDataParameter[] parameters);

        DataTable ExecuteQuery(string commandText, params IDbDataParameter[] parameters);

        int ExecuteNonQuery(string commandText, params IDbDataParameter[] parameters);
    }

    //public interface IDbCommandFactory
    //{
    //    IDbCommand CreateCommand(IDbConnection connection, string commandText);
    //}
}
