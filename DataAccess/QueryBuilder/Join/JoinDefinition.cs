using Domain.Entities;

namespace DataAccess.QueryBuilder;

public class JoinDefinition
{
    public ColumnInfo ForeignKeyColumn { get; set; } = null!;

    public JoinType JoinType { get; set; } = JoinType.Inner;
}
    //public string SchemaName { get; set; } = "dbo";
    //public string TableName { get; set; } = string.Empty;

    //public string LeftColumn { get; set; } = string.Empty;

    //public string RightColumn { get; set; } = string.Empty;