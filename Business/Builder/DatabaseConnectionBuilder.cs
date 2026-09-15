using DataAccess.Interfaces;
using DataAccess.SqlServer;
using Microsoft.Data.SqlClient;

namespace Business.Builder;

public static class DatabaseConnectionBuilder
{
    public static string Build( IDbConnectionStringBuilder builder)
    {

        string connectionString = builder.Build();


        return connectionString;
    }
}