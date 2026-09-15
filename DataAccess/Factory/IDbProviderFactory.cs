using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Factory
{
    public interface IDbProviderFactory
    {
        IDbConnectionFactory ConnectionFactory { get; }

        IDbExecutorFactory DatabaseExecutor { get; }

        IDbParameterFactory ParameterFactory { get; }

        IDbMetadataProviderFactory MetadataProvider { get; }
    }
}
