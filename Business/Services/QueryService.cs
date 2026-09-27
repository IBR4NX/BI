
using DataAccess;
using DataAccess.Factory;
using Domain.Definition;
using System.Data;
using System.Diagnostics;
using System.Text.Json;

namespace Business.Services;

public class QueryService
{
    private readonly IDbProviderFactory _dbProviderFactory;
    //private readonly QueryValidator _validator;

    public QueryService(
    IDbProviderFactory dataRepository    //QueryValidator validator
        )
    {
        _dbProviderFactory = dataRepository;
       //_validator = validator;
    }

    public DataTable Execute(string query, params IDbDataParameter[] parameters)
    {
        Debug.WriteLine(query);
        return _dbProviderFactory.DatabaseExecutor.ExecuteQuery(query, parameters );
    }

}
