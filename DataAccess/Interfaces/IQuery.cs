using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IQuery
    {

        //object CreateConnection();
        DataTable ExecuteQuery(string query, IReadOnlyDictionary<string, object?>? parameters = null);
    }
}
