using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class DbMetadata
    {
        public List<TableInfo> Tables { get; set; } = new();
        public Dictionary<TableInfo, List<ColumnInfo>> TablesInfo { get; set; } = new();
        public Dictionary<string, List<TableInfo>> treeTableInfo { get; set; } = new();
        public List<ColumnInfo> Columns { get; set; }= new();
    }
}
