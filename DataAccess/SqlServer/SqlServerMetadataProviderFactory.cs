using DataAccess.Factory;
using Domain;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

public class SqlServerMetadataProviderFactory : IDbMetadataProviderFactory
{
    private readonly IDbConnectionFactory _connectionFactory;
    private readonly IDbExecutorFactory _databaseExecutor ;
    public IDbParameterFactory _parameterFactory;
    public SqlServerMetadataProviderFactory(IDbConnectionFactory connectionFactory, IDbExecutorFactory DatabaseExecutor, IDbParameterFactory arameterFactory)
    {
        _connectionFactory = connectionFactory;
        _databaseExecutor = DatabaseExecutor;
        _parameterFactory = arameterFactory;


    }

    public List<string> GetDatabases()
    {
        List<string> databases = new();

        string query = "SELECT name FROM sys.databases ORDER BY name";

        using IDataReader reader = _databaseExecutor.ExecuteReader(query);

        while (reader.Read())
        {
            databases.Add(reader["name"].ToString()!);
        }

        return databases;
    }

    public List<string> GetSchemas()
    {
        List<string> schemas = new();

        string query = "SELECT name FROM sys.schemas ORDER BY name";

        using IDataReader reader = _databaseExecutor.ExecuteReader(query);

        while (reader.Read())
        {
            schemas.Add(reader["name"].ToString()!);
        }

        return schemas;
    }

    public List<TableInfo> GetTables()
    {
        List<string> tables = new();
        List<TableInfo> tableInfo = new();


        string query = """
        SELECT TABLE_SCHEMA, TABLE_NAME
        FROM INFORMATION_SCHEMA.TABLES
        WHERE TABLE_TYPE = 'BASE TABLE'
        ORDER BY TABLE_SCHEMA, TABLE_NAME;
        """;

        using IDataReader reader = _databaseExecutor.ExecuteReader(query);

        while (reader.Read())
        {


            tableInfo.Add( new TableInfo {
                Schema = reader["TABLE_SCHEMA"].ToString()!,
                Name = reader["TABLE_NAME"].ToString()! }
             );
        }

        return tableInfo;
    }
    public List<ColumnInfo> GetColumns()
    {
        var columns = new List<ColumnInfo>();

        string query = """
        SELECT
                s.name AS SchemaName,
                t.name AS TableName,
                c.name AS ColumnName,
                TYPE_NAME(c.user_type_id) AS DataType,
                c.is_nullable AS IsNullable,
                c.column_id AS OrdinalPosition,
                c.max_length AS MaxLength,
                c.precision AS NumericPrecision,
                c.scale AS NumericScale,

                CASE
                    WHEN pk.column_id IS NOT NULL THEN 1
                    ELSE 0
                END AS IsPrimaryKey,

                CASE
                    WHEN fkc.parent_column_id IS NOT NULL THEN 1
                    ELSE 0
                END AS IsForeignKey,

                rs.name AS ReferencedSchema,
                rt.name AS ReferencedTable,
                rc.name AS ReferencedColumn

            FROM sys.columns c

            INNER JOIN sys.tables t
                ON c.object_id = t.object_id

            INNER JOIN sys.schemas s
                ON t.schema_id = s.schema_id

            LEFT JOIN
            (
                SELECT
                    ic.object_id,
                    ic.column_id
                FROM sys.indexes i
                INNER JOIN sys.index_columns ic
                    ON i.object_id = ic.object_id
                    AND i.index_id = ic.index_id
                WHERE i.is_primary_key = 1
            ) pk
                ON c.object_id = pk.object_id
                AND c.column_id = pk.column_id

            LEFT JOIN sys.foreign_key_columns fkc
                ON c.object_id = fkc.parent_object_id
                AND c.column_id = fkc.parent_column_id

            LEFT JOIN sys.tables rt
                ON fkc.referenced_object_id = rt.object_id

            LEFT JOIN sys.schemas rs
                ON rt.schema_id = rs.schema_id

            LEFT JOIN sys.columns rc
                ON fkc.referenced_object_id = rc.object_id
                AND fkc.referenced_column_id = rc.column_id

            ORDER BY s.name, t.name, c.column_id;
        """;

        using IDataReader reader = _databaseExecutor.ExecuteReader(query);

        while (reader.Read())
        {
            columns.Add(new ColumnInfo
            {
                SchemaName = reader["SchemaName"].ToString()!,
                TableName = reader["TableName"].ToString()!,
                Name = reader["ColumnName"].ToString()!,
                DataType = reader["DataType"].ToString()!,

                IsNullable = Convert.ToBoolean(reader["IsNullable"]),

                OrdinalPosition = Convert.ToInt32(reader["OrdinalPosition"]),

                MaxLength = reader["MaxLength"] == DBNull.Value
                    ? null
                    : Convert.ToInt32(reader["MaxLength"]),

                NumericPrecision = reader["NumericPrecision"] == DBNull.Value
                    ? null
                    : Convert.ToByte(reader["NumericPrecision"]),

                NumericScale = reader["NumericScale"] == DBNull.Value
                    ? null
                    : Convert.ToInt32(reader["NumericScale"]),

                IsPrimaryKey = Convert.ToBoolean(reader["IsPrimaryKey"]),

                IsForeignKey = Convert.ToBoolean(reader["IsForeignKey"]),

                ReferencedSchema = reader["ReferencedSchema"] == DBNull.Value
                    ? null
                    : reader["ReferencedSchema"].ToString(),

                ReferencedTable = reader["ReferencedTable"] == DBNull.Value
                    ? null
                    : reader["ReferencedTable"].ToString(),

                ReferencedColumn = reader["ReferencedColumn"] == DBNull.Value
                    ? null
                    : reader["ReferencedColumn"].ToString()
            });
        }

        return columns;
    }



    //public List<ColumnInfo> GetColumns()
    //{
    //    var columns = new List<ColumnInfo>();

    //    string query = """
    //    SELECT
    //        s.name AS SchemaName,
    //        t.name AS TableName,
    //        c.name AS ColumnName,
    //        TYPE_NAME(c.user_type_id) AS DataType,
    //        c.is_nullable AS IsNullable,
    //        c.column_id AS OrdinalPosition,
    //        c.max_length AS MaxLength,
    //        c.precision AS NumericPrecision,
    //        c.scale AS NumericScale
    //    FROM sys.columns c
    //    INNER JOIN sys.tables t ON c.object_id = t.object_id
    //    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    //    ORDER BY s.name, t.name, c.column_id;
    //    """;

    //    using IDataReader reader = _databaseExecutor.ExecuteReader(query);

    //    while (reader.Read())
    //    {
    //        columns.Add(new ColumnInfo
    //        {
    //            SchemaName = reader["SchemaName"].ToString()!,
    //            TableName = reader["TableName"].ToString()!,
    //            Name = reader["ColumnName"].ToString()!,
    //            DataType = reader["DataType"].ToString()!,
    //            IsNullable = Convert.ToBoolean(reader["IsNullable"]),
    //            OrdinalPosition = Convert.ToInt32(reader["OrdinalPosition"]),
    //            MaxLength = reader["MaxLength"] == DBNull.Value
    //                ? null
    //                : Convert.ToInt32(reader["MaxLength"]),
    //            NumericPrecision = reader["NumericPrecision"] == DBNull.Value
    //                ? null
    //                : Convert.ToByte(reader["NumericPrecision"]),
    //            NumericScale = reader["NumericScale"] == DBNull.Value
    //                ? null
    //                : Convert.ToInt32(reader["NumericScale"])
    //        });
    //    }

    //    return columns;
    //}

    public HashSet<string> GetPrimaryKeys(TableInfo tableInfo)
    {
        HashSet<string> primaryKeys = new();


        const string query = """
        SELECT c.name
        FROM sys.indexes i
        INNER JOIN sys.index_columns ic
            ON i.object_id = ic.object_id
            AND i.index_id = ic.index_id
        INNER JOIN sys.columns c
            ON ic.object_id = c.object_id
            AND ic.column_id = c.column_id
        INNER JOIN sys.tables t
            ON i.object_id = t.object_id
        INNER JOIN sys.schemas s
            ON t.schema_id = s.schema_id
        WHERE i.is_primary_key = 1
          AND s.name = @SchemaName
          AND t.name = @TableName
        ORDER BY ic.key_ordinal;
        """;


        IDbDataParameter schemaParameter = _parameterFactory.CreateParameter("@SchemaName", tableInfo.Schema);
        IDbDataParameter TableParameter = _parameterFactory.CreateParameter("@TableName", tableInfo.Name);
        using IDataReader reader = _databaseExecutor.ExecuteReader(query, [schemaParameter, TableParameter] );


        while (reader.Read())
        {
            primaryKeys.Add(reader["name"].ToString()!);
        }

        return primaryKeys;
    }

    public List<ForeignKeyInfo> GetForeignKeys(string schemaName, string tableName)
    {

        using IDbConnection connection = _connectionFactory.CreateConnection();

        connection.Open();

        using IDbCommand command = connection.CreateCommand();
         string query = """
        SELECT
            c.name AS ColumnName,
            rs.name AS ReferencedSchema,
            rt.name AS ReferencedTable,
            rc.name AS ReferencedColumn
        FROM sys.foreign_key_columns fkc

        INNER JOIN sys.tables t
            ON fkc.parent_object_id = t.object_id

        INNER JOIN sys.schemas s
            ON t.schema_id = s.schema_id

        INNER JOIN sys.columns c
            ON fkc.parent_object_id = c.object_id
            AND fkc.parent_column_id = c.column_id

        INNER JOIN sys.tables rt
            ON fkc.referenced_object_id = rt.object_id

        INNER JOIN sys.schemas rs
            ON rt.schema_id = rs.schema_id

        INNER JOIN sys.columns rc
            ON fkc.referenced_object_id = rc.object_id
            AND fkc.referenced_column_id = rc.column_id

        WHERE s.name = @SchemaName
          AND t.name = @TableName

        ORDER BY fkc.constraint_column_id;
        """;

        var foreignKeys = new List<ForeignKeyInfo>();

        IDbDataParameter schemaParameter = _parameterFactory.CreateParameter("@Schema", schemaName);
        IDbDataParameter TableParameter = _parameterFactory.CreateParameter("@Table", tableName);
        using IDataReader reader = _databaseExecutor.ExecuteReader(query, [schemaParameter, TableParameter]);

        while (reader.Read())
        {
            foreignKeys.Add(new ForeignKeyInfo
            {
                ColumnName = reader.GetString(0),
                ReferencedTable = reader.GetString(2),
                ReferencedColumn = reader.GetString(3)
            });
        }

        return foreignKeys;
    }
}