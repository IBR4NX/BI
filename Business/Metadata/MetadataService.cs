
using DataAccess.Factory;
using Domain.Entities;

namespace Business.Metadata;

public class MetadataService
{
    private readonly IDbMetadataProviderFactory _dbMetadataProvider;

    public DbMetadata Metadata { get; private set; } = new();
    public MetadataService(IDbMetadataProviderFactory dbMetadataProvider)
    {
        _dbMetadataProvider = dbMetadataProvider;

    }
    public MetadataService GetMetadata()
    {
        if (Metadata.Tables.Count < 1 || Metadata.Columns.Count < 1)
        {
            LoadAllTable();
            LoadAllColumns();
        }
        foreach (var t in Metadata.Tables)
        {
            List<ColumnInfo> col = new List<ColumnInfo>();
            foreach (var c in Metadata.Columns)
            {
                if (c.TableName.Equals(t.Name) && c.SchemaName.Equals(t.Schema))
                {
                    col.Add(c);
                }
            }
            Metadata.TablesInfo.Add(t, col);
        }
        return this;

    }
    public MetadataService StorTables()
    {
        if (Metadata.Tables.Count < 1 )
        {
            LoadAllTable();
        }
        foreach (var tableInfo in Metadata.Tables)
        {
            if (Metadata.treeTableInfo.ContainsKey(tableInfo.Schema))
            {
                Metadata.treeTableInfo[tableInfo.Schema].Add(tableInfo);
            }
            else
            {
                Metadata.treeTableInfo.Add(
                    tableInfo.Schema, 
                    new List<TableInfo> { tableInfo });

            }
        }
        return this;

    }

    public void LoadAllTable()
    {
        Metadata.Tables = _dbMetadataProvider.GetTables();

    }
    public void LoadAllColumns()
    {
        Metadata.Columns = _dbMetadataProvider.GetColumns();

    }
    //public TableInfo GetTable(TableInfo table)
    //{
    //    if (!Metadata.TablesInfo.ContainsKey())
    //        return new TableInfo();

    //    return infos;
    //}
    public List<ColumnInfo> GetColumns(TableInfo table)
    {
        if (!Metadata.TablesInfo.TryGetValue(table, out var columns))
            return new List<ColumnInfo>();

        return columns;
    }
    public ColumnInfo GetColumn(string name)
    {
        ColumnInfo columnInfo = Metadata.Columns.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))!;
        if (columnInfo is null)
            return new ColumnInfo();

        return columnInfo;
    }

    public List<ColumnInfo> GetForeignKeyColumns(TableInfo tableName)
    {
        return GetColumns(tableName)
            .Where(c => c.IsForeignKey)
            .ToList();
    }

    public void PrintMetadata(TableInfo table)
    {
        Console.WriteLine("========== DATABASE METADATA ==========");

        Console.WriteLine("\nTABLES:");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"\nTABLE: : {table.Schema}, Name: {table.Name}");

        if (!Metadata.TablesInfo.TryGetValue(table, out var columnInfos))
        {
            Console.WriteLine($"  No columns found. ");
            return;
        }


        Console.WriteLine("  COLUMNS:");

        foreach (var column in columnInfos.OrderBy(c => c.OrdinalPosition))
        {
            Console.WriteLine(
                $"    Name           : {column.Name}\n" +
                $"    DataType       : {column.DataType}\n" +
                $"    Nullable       : {column.IsNullable}\n" +
                $"    Ordinal        : {column.OrdinalPosition}\n" +
                $"    MaxLength      : {column.MaxLength}\n" +
                $"    Precision      : {column.NumericPrecision}\n" +
                $"    Scale          : {column.NumericScale}\n" +
                $"    DefaultValue   : {column.DefaultValue}\n" +
                $"    PrimaryKey     : {column.IsPrimaryKey}\n" +
                $"    ForeignKey     : {column.IsForeignKey}\n" +
                $"    ReferencedSchema: {column.ReferencedSchema}\n" +
                $"    ReferencedTable: {column.ReferencedTable}\n" +
                $"    ReferencedCol  : {column.ReferencedColumn}"
            );

            Console.WriteLine("    -------------------------------");
        }


        Console.WriteLine("\n========== END METADATA ==========");
    }
}