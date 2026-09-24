using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class DbMetadata
    {
        public List<TableInfo> Tables { get; set; } = new();
        public Dictionary<TableInfo, List<ColumnInfo>> TablesInfo { get; set; } = new();
        public Dictionary<string, List<TableInfo>> treeTableInfo { get; set; } = new();
        public List<ColumnInfo> Columns { get; set; } = new();
    }


    public class clsMetadata
    {
        public string NameOfDatabase { get; set; } = string.Empty;
        private HashSet<string> _databases = new();
        public Dictionary<string, DbMetadata> Metadata { get; set; } = new();



        public List<string> Databases { get {
                return _databases.ToList();
            } set
            {
                if (value is List<string>)_databases = value.ToHashSet();
                else if (value is HashSet<string>) _databases = value.ToHashSet();
                else return;
            }
        }



        public List<TableInfo> Tables
        {
            get
            {
                if (Metadata.Count > 0 && Metadata.ContainsKey(NameOfDatabase))
                    return Metadata[NameOfDatabase].Tables;
                return new List<TableInfo>();
            }
            set
            {
                if (Metadata.ContainsKey(NameOfDatabase))
                    Metadata[NameOfDatabase].Tables = value;
                else
                    Metadata.Add(NameOfDatabase, new DbMetadata
                    {
                        Tables = value
                    });
            }
        }
        public Dictionary<TableInfo, List<ColumnInfo>> TablesInfo
        {
            get
            {
                if (Metadata.Count > 0 && Metadata.ContainsKey(NameOfDatabase))
                    return Metadata[NameOfDatabase].TablesInfo;
                return new Dictionary<TableInfo, List<ColumnInfo>>();
            }
            set
            {
                if (Metadata.ContainsKey(NameOfDatabase))
                    Metadata[NameOfDatabase].TablesInfo = value;
                else
                    Metadata.Add(NameOfDatabase, new DbMetadata
                    {
                        TablesInfo = value
                    });
            }

        }
        public Dictionary<string, List<TableInfo>> treeTableInfo
        {
            get
            {
                if (Metadata.Count > 0 && Metadata.ContainsKey(NameOfDatabase))
                    return Metadata[NameOfDatabase].treeTableInfo;
                return new Dictionary<string, List<TableInfo>>();
            }
            set
            {
                if (Metadata.ContainsKey(NameOfDatabase))
                    Metadata[NameOfDatabase].treeTableInfo = value;
                else
                    Metadata.Add(NameOfDatabase, new DbMetadata
                    {
                        treeTableInfo = value
                    });
            }
        }
        public List<ColumnInfo> Columns
        {
            get
            {
                if (Metadata.Count > 0 && Metadata.ContainsKey(NameOfDatabase))
                    return Metadata[NameOfDatabase].Columns;
                return new List<ColumnInfo>();
            }
            set
            {
                if (Metadata.ContainsKey(NameOfDatabase))
                    Metadata[NameOfDatabase].Columns = value;
                else
                    Metadata.Add(NameOfDatabase, new DbMetadata
                    {
                        Columns = value
                    });
            }
        }

    }
}
