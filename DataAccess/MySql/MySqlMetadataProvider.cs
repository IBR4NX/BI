//using DataAccess.Factory;
//using System.Data;

//namespace DataAccess.MySql
//{
//    public class MySqlMetadataProvider : IDbMetadataProviderFactory
//    {
//        private readonly IDbConnectionFactory _connectionFactory;

//        public MySqlMetadataProvider(IDbConnectionFactory connectionFactory)
//        {
//            _connectionFactory = connectionFactory;
//        }

//        public List<string> GetDatabases()
//        {
//            List<string> databases = new();

//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = "SELECT name FROM sys.databases ORDER BY name";

//            using IDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                databases.Add(reader["name"].ToString()!);
//            }

//            return databases;
//        }

//        public List<string> GetSchemas()
//        {
//            List<string> schemas = new();

//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = "SELECT name FROM sys.schemas ORDER BY name";

//            using IDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                schemas.Add(reader["name"].ToString()!);
//            }

//            return schemas;
//        }

//        public List<string> GetTables()
//        {
//            List<string> tables = new();

//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = """
//            SELECT t.name
//            FROM sys.tables t
//            INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
//            WHERE s.name = @Schema
//            ORDER BY t.name
//            """;

//            IDbDataParameter parameter = command.CreateParameter();

//            parameter.ParameterName = "@Schema";


//            command.Parameters.Add(parameter);

//            using IDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                tables.Add(reader["name"].ToString()!);
//            }

//            return tables;
//        }

//        public List<string> GetColumns(string schema, string table)
//        {
//            List<string> columns = new();

//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = """
//            SELECT c.name
//            FROM sys.columns c
//            INNER JOIN sys.tables t ON c.object_id = t.object_id
//            INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
//            WHERE s.name = @Schema
//              AND t.name = @Table
//            ORDER BY c.column_id
//            """;

//            IDbDataParameter schemaParameter = command.CreateParameter();

//            schemaParameter.ParameterName = "@Schema";
//            schemaParameter.Value = schema;

//            command.Parameters.Add(schemaParameter);

//            IDbDataParameter tableParameter = command.CreateParameter();

//            tableParameter.ParameterName = "@Table";
//            tableParameter.Value = table;

//            command.Parameters.Add(tableParameter);

//            using IDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                columns.Add(reader["name"].ToString()!);
//            }

//            return columns;
//        }

//        public List<string> GetPrimaryKeys(string schema, string table)
//        {
//            List<string> primaryKeys = new();

//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = """
//            SELECT c.name
//            FROM sys.indexes i
//            INNER JOIN sys.index_columns ic
//                ON i.object_id = ic.object_id
//                AND i.index_id = ic.index_id
//            INNER JOIN sys.columns c
//                ON ic.object_id = c.object_id
//                AND ic.column_id = c.column_id
//            INNER JOIN sys.tables t
//                ON i.object_id = t.object_id
//            INNER JOIN sys.schemas s
//                ON t.schema_id = s.schema_id
//            WHERE i.is_primary_key = 1
//              AND s.name = @Schema
//              AND t.name = @Table
//            ORDER BY ic.key_ordinal
//            """;

//            IDbDataParameter schemaParameter = command.CreateParameter();

//            schemaParameter.ParameterName = "@Schema";
//            schemaParameter.Value = schema;

//            command.Parameters.Add(schemaParameter);

//            IDbDataParameter tableParameter = command.CreateParameter();

//            tableParameter.ParameterName = "@Table";
//            tableParameter.Value = table;

//            command.Parameters.Add(tableParameter);

//            using IDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                primaryKeys.Add(reader["name"].ToString()!);
//            }

//            return primaryKeys;
//        }

//        public List<string> GetForeignKeys(string schema, string table)
//        {
//            List<string> foreignKeys = new();

//            using IDbConnection connection = _connectionFactory.CreateConnection();

//            connection.Open();

//            using IDbCommand command = connection.CreateCommand();

//            command.CommandText = """
//            SELECT fk.name
//            FROM sys.foreign_keys fk
//            INNER JOIN sys.tables t
//                ON fk.parent_object_id = t.object_id
//            INNER JOIN sys.schemas s
//                ON t.schema_id = s.schema_id
//            WHERE s.name = @Schema
//              AND t.name = @Table
//            ORDER BY fk.name
//            """;

//            IDbDataParameter schemaParameter = command.CreateParameter();

//            schemaParameter.ParameterName = "@Schema";
//            schemaParameter.Value = schema;

//            command.Parameters.Add(schemaParameter);

//            IDbDataParameter tableParameter = command.CreateParameter();

//            tableParameter.ParameterName = "@Table";
//            tableParameter.Value = table;

//            command.Parameters.Add(tableParameter);

//            using IDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                foreignKeys.Add(reader["name"].ToString()!);
//            }

//            return foreignKeys;
//        }
//    }
//}
