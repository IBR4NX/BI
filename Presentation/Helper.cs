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
    public class AppEvents
    {
        public event EventHandler? TablesChanged;

        public void NotifyTablesChanged()
        {
            TablesChanged?.Invoke(this, EventArgs.Empty);
        }
    }
    public delegate void RefreshNavigatorFolderHandler();




    public static class EventCenterAction
    {
        public static event Action? RefreshNavigator;
        public static TableInfo _selectedTableInfo= new();
        public static List<FilterDefinition> _filters = new();

        public static void NotifyRefresh()
        {
            RefreshNavigator?.Invoke();
        }
    }
}
