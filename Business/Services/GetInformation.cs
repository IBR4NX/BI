using Business.Metadata;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public static class GetInformation
    {
        public static ColumnInfo GetPrimaryKeyColumn(TableInfo tableInfo)
        {
            ColumnInfo? primaryKeyColumn = MetadataService.GetPrimaryKeyColumn(tableInfo);
            if (primaryKeyColumn != null) return primaryKeyColumn;
            return new ColumnInfo();
        }

    }
}
