
using DataAccess.Factory;
using Domain.Entities;
using System.Diagnostics;

namespace Business.Metadata;

public static class MetadataService
{
    private static IDbMetadataProviderFactory _dbMetadataProvider;

    //public static DbMetadata Metadata { get; private set; } = new();
    public static clsMetadata Metadata { get; private set; } = new clsMetadata();


    public static void MetadataProvider(IDbMetadataProviderFactory dbMetadataProvider)
    {
        _dbMetadataProvider = dbMetadataProvider;
        //return this;
    }
    public static void CorrectDataBase(string database)
    {
        Metadata.NameOfDatabase=database;
        //return this;
        Debug.WriteLine("MetadataService.CorrectDataBase: " + database);
        System.Diagnostics.StackTrace stackTrace = new();
        Console.WriteLine(stackTrace);
    }
    public static void GetDatabases()
    {
        if (_dbMetadataProvider == null)
        {
            return;
        }
        Metadata.Databases= _dbMetadataProvider.GetDatabases();
    }

    public static void GetMetadata()
    {
        Debug.WriteLine("MetadataService.GetMetadata: "  );
        if (Metadata.Tables.Count < 1)
            LoadAllTable();
        if (Metadata.Columns.Count < 1)
            LoadAllColumns();
        if (Metadata.TablesInfo.Count > 0)
            return;

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

    }
    public static void StorTables()
    {
        Debug.WriteLine("MetadataService.StorTables: " );
        if (Metadata.Tables.Count==0 )
        {
            LoadAllTable();
        }
        if (Metadata.treeTableInfo.Count > 0)
            return;

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

    }

    public static void LoadAllTable()
    {
        Debug.WriteLine("MetadataService.LoadAllTable: ");

        Metadata.Tables = _dbMetadataProvider.GetTables();

    }
    public static void LoadAllColumns()
    {
        var c = _dbMetadataProvider.GetColumns();
        Debug.WriteLine("MetadataService.LoadAllColumns: "+c.Count);
        Metadata.Columns =c;

    }

    public static List<ColumnInfo> GetColumns(TableInfo table)
    {
        Debug.WriteLine("MetadataService.GetColumns: " + table.Name);
        if (!Metadata.TablesInfo.TryGetValue(table, out var columns))
            return new List<ColumnInfo>();

        return columns;
    }
    public static ColumnInfo GetColumn(string name)
    {
        Debug.WriteLine("MetadataService.GetColumn: ");
        ColumnInfo columnInfo = Metadata.Columns.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))!;
        if (columnInfo is null)
            return new ColumnInfo();

        return columnInfo;
    }

    public static List<ColumnInfo> GetForeignKeyColumns(TableInfo tableName)
    {
        return GetColumns(tableName)
            .Where(c => c.IsForeignKey)
            .ToList();
    }
    public static ColumnInfo GetPrimaryKeyColumn(TableInfo tableName)
    {
        return GetColumns(tableName).FirstOrDefault(c => c.IsPrimaryKey)! ;
    }


    #region PrintMetadata in console
    public static void PrintMetadata(TableInfo table)
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
    #endregion
}