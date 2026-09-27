using Domain.Definition;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.QueryBuilder
{
    public interface IQueryBuilder
    {
        IQueryBuilder Select(List<ColumnInfo> columns);

        IQueryBuilder From(TableInfo tableInfo);

        IQueryBuilder Join(JoinDefinition join);

        IQueryBuilder? Where(FilterDefinition filter);
        IQueryBuilder Where(List<FilterDefinition> filter);

        IQueryBuilder OrderBy(string column, bool descending = false);

        string Build();
        List<IDbDataParameter> GetParameters();
    }
    public interface IDeleteQueryBuilder
    {
        IDeleteQueryBuilder From(TableInfo tableInfo);
        IDeleteQueryBuilder Where(List<FilterDefinition> filters);

        string Build();
        List<IDbDataParameter> GetParameters();
    }
}
