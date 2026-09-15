
//using Business.Metadata;
//using DataAccess.Factory;
//using DataAccess.QueryBuilder;
//using DataAccess.SqlServer;
//using Domain.Entities;
//using System.Data;




//try
//{

//    string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AdventureWorks2025;Trusted_Connection=True;TrustServerCertificate=True;";

//    IDbProviderFactory providerFactory = new SqlServerDatabaseProviderFactory(connectionString);

//    MetadataService meta = new MetadataService(providerFactory.MetadataProvider);
//    //meta.LoadAllTable();
//    //meta.LoadAllColumns();
//    meta.GetMetadata();
//    meta.PrintMetadata(meta.Metadata.Tables[46]);
//    //foreach (var item in meta.Metadata.TablesInfo)
//    //{

//    //Console.WriteLine($"Count columns: {item.Key.Schema} - {item.Key.Name} - {item.Value.Count}");
//    //}
//    Console.WriteLine(providerFactory.MetadataProvider.GetPrimaryKeys(meta.Metadata.Tables[5]).ToString());



//    ColumnInfo foreignKeyColumn = meta.Metadata.Columns.First(c =>
//        c.IsForeignKey &&
//        c.TableName == "SalesOrderHeader" &&
//        c.Name == "CustomerID");

//    JoinDefinition join = new JoinDefinition
//    {
//        ForeignKeyColumn = foreignKeyColumn,
//        JoinType = JoinType.Inner
//    };

//    IQueryBuilder builder = new QueryBuilder();

//    string query = builder
//        .Select(
//            "SalesOrderHeader.SalesOrderID",
//            "SalesOrderHeader.CustomerID",
//            "Customer.AccountNumber")
//        .From("Sales", "SalesOrderHeader")
//        .Join(join)
//        .Build();

//    Console.WriteLine(query);



//}
//catch (Exception ex)
//{
//    Console.WriteLine("Error:");
//    Console.WriteLine(ex);
//}


