using DataAccess.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.SqlServer
{
    public class SqlServerDatabaseProviderFactory : IDbProviderFactory
    {
        public IDbConnectionFactory ConnectionFactory { get; }

        public IDbExecutorFactory DatabaseExecutor { get; }

        public IDbParameterFactory ParameterFactory { get; }

        public IDbMetadataProviderFactory MetadataProvider { get; }

        public SqlServerDatabaseProviderFactory(string connectionString)
        {
            ConnectionFactory = new SqlServerConnectionFactory(connectionString);

            DatabaseExecutor = new SqlServerExecutorFactory(ConnectionFactory);

            ParameterFactory = new SqlServerParameterFactory();

            MetadataProvider = new SqlServerMetadataProviderFactory(ConnectionFactory, DatabaseExecutor, ParameterFactory);
        }
    }
}
