using DataAccess.Interfaces;
using Domain.Settings;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.SqlServer
{

    public class SqlServerConnectionStringBuilder : IDbConnectionStringBuilder
    {
        public string Server { get; set; } = ".";

        public int? Port { get; set; } = 1433;

        public string Database { get; set; } = "";

        public string Username { get; set; } = "";

        public string Password { get; set; } = "";

        public SqlServerConnectionStringBuilder(ConnectionSettings builder) {
            this.Server = builder.Server;   
            //this.Port = builder.Port;
            //this.Database = builder.Database;
            //this.Username = builder.Username;
            //this.Password = builder.Password;
        }

        public string Build()
        {
            SqlConnectionStringBuilder builder = new();

            builder.DataSource = $"{Server},{Port}";
            if(Database != null)
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
