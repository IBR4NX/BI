using System.Data;
namespace DataAccess.Factory
{
    public interface IDbConnectionFactory
    {
        IDbConnection connection { get; set; }

        IDbConnection CreateConnection();
        IDbConnection OpenConnection();
    }
}