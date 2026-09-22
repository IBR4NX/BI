using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Factory
{
    public interface IDbProviderFactory
    {
        IDbConnectionFactory ConnectionFactory { get; set; }

        IDbExecutorFactory DatabaseExecutor { get; set; }

        IDbParameterFactory ParameterFactory { get; set; }

        IDbMetadataProviderFactory MetadataProvider { get; set; }
        void ReBuild(string connectionString);
    }
}
