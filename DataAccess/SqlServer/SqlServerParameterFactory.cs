using DataAccess.Factory;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess.SqlServer
{
    public class SqlServerParameterFactory : IDbParameterFactory
    {
        public IDbDataParameter CreateParameter(string name, object? value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }
    }
}