using Domain.Entities;

namespace Domain.Definition;

public enum FilterValueType
{
    Value,
    Column
}

public class FilterDefinition
{
    public ColumnInfo Column { get; set; } = new();

    public ComparisonOperator Operator { get; set; }

    public FilterValueType? ValueType { get; set; }

    public object? Value { get; set; }

    public string? ValueColumnName { get; set; }

    public List<object> Values { get; set; } = new();

    public LogicalOperator? LogicalOperator { get; set; }

}
