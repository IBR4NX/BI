using Domain.Entities;
using System.Data;

namespace DataAccess.Interfaces
{
    public interface IDbConnectionStringBuilder
    {
        string Server { get; set; }

        int Port { get; set; }

        string Database { get; set; }

        string Username { get; set; }

        string Password { get; set; }

        string Build();
    }
}
