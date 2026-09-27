using Domain.Interfaces;
using Domain.Settings;
using System.Data;

namespace DataAccess.Factory
{
    public interface IDbConnectionStringBuilder 
    {
        IConnectionSettings ConnectionSettings { get; set; }
        string Build();
    }
}
