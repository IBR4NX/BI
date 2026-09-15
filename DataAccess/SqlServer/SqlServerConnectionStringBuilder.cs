using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Interfaces;
using Microsoft.Data.SqlClient;

namespace DataAccess.SqlServer
{

    public class SqlServerConnectionStringBuilder : IDbConnectionStringBuilder
    {
        public string Server { get; set; } = "localhost";

        public int Port { get; set; } = 1433;

        public string Database { get; set; } = "";

        public string Username { get; set; } = "";

        public string Password { get; set; } = "";

        public string Build()
        {
            SqlConnectionStringBuilder builder = new();

            builder.DataSource = $"{Server},{Port}";
            builder.InitialCatalog = Database;

            if (!string.IsNullOrWhiteSpace(Username))
            {
                builder.UserID = Username;
                builder.Password = Password;
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
