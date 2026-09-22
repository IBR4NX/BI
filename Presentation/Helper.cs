using Domain;
using Domain.Definition;
using Domain.Entities;
using System.Data;

namespace Presentation
{
    internal static class Helper
    {
        public static void Show(string message, string caption = "Business Intelligence", MessageBoxIcon icon = MessageBoxIcon.Warning)
        {
            MessageBox.Show(
                message,
                caption,
                MessageBoxButtons.OK,
                icon);
        }

    }
    public static class EventsDB
    {
        public static event Action DatabaseChanged;
        public static string _database;

        public static void NotifyDatabasesChanged(string? database)
        {
            _database = database;
            DatabaseChanged?.Invoke();
        }
    }
    public delegate void RefreshNavigatorFolderHandler();




    public static class EventCenterAction
    {
        public static event Action? RefreshNavigator;
        public static event Action? RefreshDatabase;
        public static TableInfo _selectedTableInfo= new();
        public static List<FilterDefinition> _filters = new();
        public static List<string> _database = new();
        public static void NotifyRefresh()
        {
            RefreshNavigator?.Invoke();
        }
    }
}
