using DataAccess.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.SqlServer
{
    public class SqlServerDatabaseProviderFactory : IDbProviderFactory
    {
        public IDbConnectionFactory ConnectionFactory { get; set; }

        public IDbExecutorFactory DatabaseExecutor { get; set; }

        public IDbParameterFactory ParameterFactory { get; set; }

        public IDbMetadataProviderFactory MetadataProvider { get; set; }

        public SqlServerDatabaseProviderFactory(string connectionString)
        {
            ConnectionFactory = new SqlServerConnectionFactory(connectionString);

            DatabaseExecutor = new SqlServerExecutorFactory(ConnectionFactory);

            ParameterFactory = new SqlServerParameterFactory();

            MetadataProvider = new SqlServerMetadataProviderFactory(ConnectionFactory, DatabaseExecutor, ParameterFactory);
        }
        public void ReBuild(string connectionString)
        {
            ConnectionFactory = new SqlServerConnectionFactory(connectionString);

            DatabaseExecutor = new SqlServerExecutorFactory(ConnectionFactory);

            ParameterFactory = new SqlServerParameterFactory();

            MetadataProvider = new SqlServerMetadataProviderFactory(ConnectionFactory, DatabaseExecutor, ParameterFactory);

        }
    }
}
