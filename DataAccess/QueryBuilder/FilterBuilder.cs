using DataAccess.Factory;
using Domain.Definition;
using System.Data;

namespace DataAccess;

public class FilterBuilder
{
    private readonly List<IDbDataParameter> _parameters = new();
    private readonly IDbParameterFactory _dbDataParameter;
    public FilterBuilder(IDbParameterFactory dbDataParameter)
    {
        _dbDataParameter = dbDataParameter;
    }
    public FilterResult Build(FilterDefinition filter, ref int parameterIndex)
    {
        string column = $"[{filter.Column.Name}]";

        return filter.Operator switch
        {
            ComparisonOperator.Equal =>
                BuildSingleValue(column, "=", filter, ref parameterIndex),

            ComparisonOperator.NotEqual =>
                BuildSingleValue(column, "<>", filter, ref parameterIndex),

            ComparisonOperator.GreaterThan =>
                BuildSingleValue(column, ">", filter, ref parameterIndex),

            ComparisonOperator.LessThan =>
                BuildSingleValue(column, "<", filter, ref parameterIndex),

            ComparisonOperator.GreaterThanOrEqual =>
                BuildSingleValue(column, ">=", filter, ref parameterIndex),

            ComparisonOperator.LessThanOrEqual =>
                BuildSingleValue(column, "<=", filter, ref parameterIndex),

            ComparisonOperator.Like =>
                BuildSingleValue(column, "LIKE", filter, ref parameterIndex),

            ComparisonOperator.Between =>
                BuildBetween(column, filter, ref parameterIndex),

            ComparisonOperator.In =>
                BuildIn(column, filter, ref parameterIndex),

            ComparisonOperator.IsNull =>
                new FilterResult
                {
                    Sql = $"{column} IS NULL"
                },

            ComparisonOperator.IsNotNull =>
                new FilterResult
                {
                    Sql = $"{column} IS NOT NULL"
                },

            _ => throw new NotSupportedException(
                $"Operator {filter.Operator} is not supported.")
        };
    }

    private FilterResult BuildSingleValue(
        string column,
        string sqlOperator,
        FilterDefinition filter,
        ref int parameterIndex)
    {
        if (filter.Values == null || filter.Values.Count == 0)
            throw new InvalidOperationException("This operator requires a value.");

        object? value = filter.Values[0];

        string parameterName = $"@p{parameterIndex++}";
        FilterResult f = new FilterResult
        {
            Sql = $"{column} {sqlOperator} {parameterName}",
            Parameters = [_dbDataParameter.CreateParameter(parameterName, value ?? DBNull.Value)]
        };
        return f;
    }

    private FilterResult BuildBetween(
        string column,
        FilterDefinition filter,
        ref int parameterIndex)
    {
        if (filter.Values == null || filter.Values.Count < 2)
            throw new InvalidOperationException(
                "Between requires two values.");

        string firstParameter = $"@p{parameterIndex++}";
        string secondParameter = $"@p{parameterIndex++}";

        return new FilterResult
        {
            Sql = $"{column} BETWEEN {firstParameter} AND {secondParameter}",

            Parameters = [
                _dbDataParameter.CreateParameter(firstParameter, filter.Values[0] ?? DBNull.Value),
                _dbDataParameter.CreateParameter(secondParameter, filter.Values[1] ?? DBNull.Value)
            ]
        };
    }

    private FilterResult BuildIn(
        string column,
        FilterDefinition filter,
        ref int parameterIndex)
    {
        if (filter.Values == null || filter.Values.Count == 0)
            throw new InvalidOperationException(
                "In requires at least one value.");

        var parameterNames = new List<string>();

        var result = new FilterResult();

        foreach (object? value in filter.Values)
        {
            string parameterName = $"@p{parameterIndex++}";


            result.Parameters.Add(_dbDataParameter.CreateParameter( parameterName, value ?? DBNull.Value));
        }

        result.Sql = $"{column} IN ({string.Join(", ", parameterNames)})";

        return result;
    }
}

public class FilterResult
{
    public string Sql { get; set; } = string.Empty;

    public List<IDbDataParameter> Parameters { get; set; } = new();
}