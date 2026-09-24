using Business.Metadata;
using Domain.Definition;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Presentation
{
    public class clsEventActions
    {
        public static event Action<string> DatabaseChanged = delegate { };
        public static event Action<TableInfo> TableSelected= ChangeColumns;
        public static event Action<List<ColumnInfo>> ColumnsChanged= delegate { };

        public static void ChangeDatabase(string? database)
        {
            if(database is string)
            DatabaseChanged.Invoke(database);
        }
        public static void SelectTable(TableInfo tableInfo)
        {
            if (tableInfo == null)
                return;
            TableSelected.Invoke(tableInfo);

            Debug.WriteLine(" SelectTable");
        }

        public static void ChangeColumns(TableInfo tableInfo)
        {
            if (tableInfo == null)
                return;
            List<ColumnInfo> columns = MetadataService.GetColumns(tableInfo);
            ColumnsChanged.Invoke(columns);

            Debug.WriteLine(" SelectTable");
        }


    }
    #region
    public class eventBI
    {
        // Events 
        //public event EventHandler? EventHandlerChanged= on;
        private static event Action TableSelected = delegate { };
        public static event Action DatabaseChanged = delegate { };

        public static event Action RefreshNavigator = OnRefreshNavigator;
        public static void NotifyRefresh()
        {
            RefreshNavigator?.Invoke();
        }
        public static void OnRefreshNavigator()
        {
            Debug.WriteLine("");
        }


        public static event Action TableChanged = delegate { };


        public static TableInfo CorrectTable
        {
            get => field;
            set
            {
                field = value;
                TableSelected.Invoke();
            }
        } = new();

        public static string CorrectDatabase
        {
            get => field;
            set
            {
                field = value;
                DatabaseChanged.Invoke();
            }
        } = string.Empty;


        public static List<FilterDefinition> filters
        {
            get; set
            {
                if (value is List<FilterDefinition>)
                {
                    if (value.Count == 1) field.Add(value.First());
                    else field.AddRange(value);
                }
            }
        } = new();
    }
    #endregion
}
