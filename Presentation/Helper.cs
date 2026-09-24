using Domain;
using Domain.Definition;
using Domain.Entities;
using System.Data;
using System.Diagnostics;

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
       public static void MyMethod()
        {
            StackTrace stackTrace = new StackTrace(true);
            StackFrame? frame = stackTrace.GetFrame(1);
            string filename = frame.GetFileName().Replace("C:\\Users\\IBOVS\\source\\repos\\", "BI: ");
            Console.WriteLine($"Method: {frame?.GetMethod()?.Name}" + $"File: {filename}" + $"Line: {frame?.GetFileLineNumber()}");
        }

    }




    public static class EventCenterAction
    {
        public static event Action? RefreshNavigator;
        public static event Action? RefreshDatabase;
        public static List<string> _database = new();
        public static TableInfo _selectedTableInfo = new();

        private static event Action TableSelected = delegate { };
        public static event Action DatabaseChanged = delegate { };

        public static void NotifyRefresh()
        {
            RefreshNavigator?.Invoke();
        }

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
}
