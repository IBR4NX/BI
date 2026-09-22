using DataAccess.Interfaces;
using DataAccess.SqlServer;
using System.Data;


namespace Business.Builder;

public static class DatabaseConnectionBuilder
{
    public static SqlServerConnectionStringBuilder s;

    public static string Build( string Server)
    {

         //s = new SqlServerConnectionStringBuilder();

        return s.Build();
    }

}