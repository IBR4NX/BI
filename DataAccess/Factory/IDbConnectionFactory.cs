using System.Data;
namespace DataAccess.Factory
{
    public interface IDbConnectionFactory
    {
        IDbConnection Connection { get; set; }

        IDbConnection CreateConnection();
        IDbConnection OpenConnection();

        bool ConnectionOpened();
    }
}