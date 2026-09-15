using System.Data;
namespace DataAccess.Factory
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}