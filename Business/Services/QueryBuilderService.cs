using DataAccess.Factory;
using DataAccess.QueryBuilder;
using Domain.Definition;
using Domain.Entities;
using System.Diagnostics;


namespace Business.Services
{
    public class QueryBuilderService
    {
        public static IDbProviderFactory _ProviderFactory { get; set; } 
        public static bool ProviderExit;
        public QueryBuilderService(IDbProviderFactory providerFactory)
        {
           _ProviderFactory = providerFactory;
            ProviderExit = true;
        }

        public static bool DeleteColumns(TableInfo tableInfo, FilterDefinition filter)
        {
            if (!ProviderISExit()) Debug.WriteLine("proFalse") ;
            QueryBuilder deleteQuery = new QueryBuilder(_ProviderFactory.ParameterFactory);
            deleteQuery.Delete.From(tableInfo).Where(filter );
            string q = deleteQuery.Build();
            Debug.WriteLine(q); 
            Debug.WriteLine(filter.Column.Name+" "+filter.GetValuesString());
            _ProviderFactory.DatabaseExecutor.ExecuteNonQuery(q, deleteQuery.GetParameters().ToArray());
            return true;
        }
        public static bool ProviderISExit()
        {
            if (_ProviderFactory == null) 
                return false;
            return true;
        }
    }
}
