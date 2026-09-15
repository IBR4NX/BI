using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Factory
{
    public interface IDbMetadataProviderFactory
    {
        List<string> GetDatabases();

        List<string> GetSchemas();

        List<TableInfo> GetTables();

        List<ColumnInfo> GetColumns();

        HashSet<string> GetPrimaryKeys(TableInfo table);

        List<ForeignKeyInfo> GetForeignKeys(string schemaName, string tableNamee);
    }
}
