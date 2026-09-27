
using System.Data.Common;

namespace Domain.Entities
{
    public class TableInfo
    {
        public string Schema { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string PrimaryKeyColumn {  get; set; }= string.Empty;
        public ICollection<ColumnInfo>? Columns { get; set; } = new List<ColumnInfo>();

    }

}
