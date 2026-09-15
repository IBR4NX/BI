//using DataAccess.Factory;
//using System;
//using System.Collections.Generic;
//using System.Text;


//namespace DataAccess.MySql
//{
//    public class MySqlDatabaseProvider : IDbProviderFactory
//    {
//        public IDbConnectionFactory ConnectionFactory { get; }

//        public IDbExecutorFactory DatabaseExecutor { get; }

//        public IDbParameterFactory ParameterFactory { get; }

//        public IDbMetadataProviderFactory MetadataProvider { get; }

//        public MySqlDatabaseProvider(string connectionString)
//        {
//            ConnectionFactory = new MySqlConnectionFactory(connectionString);

//            DatabaseExecutor = new MySqlExecutor(ConnectionFactory);

//            ParameterFactory = new MySqlParameter();

//            //MetadataProvider = new MySqlMetadataProvider(ConnectionFactory);
//        }
//    }
//}
