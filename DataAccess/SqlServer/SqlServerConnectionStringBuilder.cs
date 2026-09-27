using DataAccess.Factory;
using Domain.Interfaces;
using Domain.Settings;
using Microsoft.Data.SqlClient;

namespace DataAccess.SqlServer
{

    public class SqlServerConnectionStringBuilder : IDbConnectionStringBuilder
    {
        public IConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();

        public SqlServerConnectionStringBuilder(IConnectionSettings? connectionSettings=null) {
            if (connectionSettings != null)
            {
                if (connectionSettings.Server != string.Empty)
                    ConnectionSettings.Server = connectionSettings.Server;
            }
          
        }

        public string Build()
        {
            SqlConnectionStringBuilder builder = new();

            builder.DataSource = $"{ConnectionSettings.Server},{ConnectionSettings.Port}";
            if(ConnectionSettings.Database != null)
            builder.InitialCatalog = ConnectionSettings.Database;

            if (!string.IsNullOrWhiteSpace(ConnectionSettings.Username))
            {
                builder.UserID = ConnectionSettings.Username;
                builder.Password = ConnectionSettings.Password;
                builder.IntegratedSecurity = false;
            }
            else
            {
                builder.IntegratedSecurity = true;
            }

            builder.TrustServerCertificate = true;

            return builder.ConnectionString;
        }
    }
}
