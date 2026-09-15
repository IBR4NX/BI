using DataAccess.Factory;
using Domain.Definition;
using Domain.Entities;
using System.Data;

namespace DataAccess.QueryBuilder
{
    public class QueryBuilder : IQueryBuilder
    {
        private  List<ColumnInfo> _columns = new();

        private  List<JoinDefinition> _joins = new();

        private  List<string> _conditions = new();

        private string? _schema;

        private string? _table;

        private string? _orderBy;
        private  FilterBuilder _filterBuilder ;
        private List<IDbDataParameter> _parameters = new();
        private IDbParameterFactory _ParameterFactory;

        private int _parameterIndex;
        public QueryBuilder(IDbParameterFactory parameterFactory)
        {
            _ParameterFactory = parameterFactory;
            _filterBuilder = new FilterBuilder(_ParameterFactory);
        }
        public IQueryBuilder Select(List<ColumnInfo> columns)
        {
            _columns.Clear();

            _columns.AddRange(columns);

            return this;
        }

        public IQueryBuilder From(TableInfo tableInfo)
        {
            _schema = tableInfo.Schema;

            _table =tableInfo.Name;

            return this;
        }

        public IQueryBuilder Join(JoinDefinition join)
        {
            _joins.Add(join);

            return this;
        }

        public IQueryBuilder Where(List<FilterDefinition> filter)
        {
            FilterResult result = new FilterResult();
            foreach (FilterDefinition filterDef in filter) {
                result = _filterBuilder.Build(filterDef, ref _parameterIndex);
                _conditions.Add(result.Sql);
                foreach (var parameter in result.Parameters)
                {
                    _parameters.Add(parameter);
                }
            }

            return this;
        }
        public IQueryBuilder OrderBy(string column, bool descending = false)
        {
            _orderBy = descending
                ? $"{column} DESC"
                : $"{column} ASC";

            return this;
        }

        public string Build()
        {
            if (string.IsNullOrWhiteSpace(_table))
                throw new InvalidOperationException("Table is required.");

            string columns = _columns.Count > 0
                ? string.Join(", ", _columns.Select(c => string.IsNullOrWhiteSpace(c.SchemaName) ? $"[{c.TableName}].[{c.Name}]"
                    : $"[{c.SchemaName}].[{c.TableName}].[{c.Name}]"))
                : "*";

            string from = string.IsNullOrWhiteSpace(_schema)
                ? _table
                : $"[{_schema}].[{_table}]";

            string query = $"SELECT {columns} FROM {from}";

            foreach (JoinDefinition join in _joins)
            {
                ColumnInfo fk = join.ForeignKeyColumn;

                string joinType = join.JoinType switch
                {
                    JoinType.Inner => "INNER JOIN",
                    JoinType.Left => "LEFT JOIN",
                    JoinType.Right => "RIGHT JOIN",
                    JoinType.Full => "FULL OUTER JOIN",
                    _ => throw new ArgumentOutOfRangeException()
                };

                string referencedTable = string.IsNullOrWhiteSpace(fk.ReferencedSchema)
                    ? fk.ReferencedTable!
                    : $"{fk.ReferencedSchema}.{fk.ReferencedTable}";

                query += $" {joinType} {referencedTable} ON {fk.TableName}.{fk.Name} = {referencedTable}.{fk.ReferencedColumn}";
            }

            if (_conditions.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", _conditions);
            }

            if (!string.IsNullOrWhiteSpace(_orderBy))
            {
                query += $" ORDER BY {_orderBy}";
            }

            return query;
        }
        public List<IDbDataParameter> GetParameters()
        {
            return _parameters;
        }
    //    private string BuildWhere(
    //QueryDefinition query,
    //Dictionary<string, object?> queryParameters)
    //    {
    //        if (query.Filters.Count == 0)
    //            return string.Empty;

    //        var conditions = new List<string>();

    //        int parameterIndex = 0;
    //        for (int i = 0; i < query.Filters.Count; i++)
    //        {

    //            FilterResult filterResult = _filterBuilder.Build(query.Filters[i], ref parameterIndex);
    //            string condition = filterResult.Sql;
    //            Debug.WriteLine(condition);

    //            foreach (var parameter in filterResult.Parameters)
    //                queryParameters.Add(parameter.Key, parameter.Value);

    //            if (i > 0)
    //            {
    //                string logicalOperator =
    //                    query.Filters[i].LogicalOperator
    //                        == LogicalOperator.And ? "AND" : "OR";

    //                condition = $"{logicalOperator} {condition}";
    //            }

    //            conditions.Add(condition);
    //        }
        }
}
