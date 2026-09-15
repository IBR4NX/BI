
namespace Domain.Entities
{
    public class TableInfo
    {
        public string Schema { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
    public  interface ITableInfo
    {
        public static string Schema { get; set; } = string.Empty;
        public static string Name { get; set; } = string.Empty;
    }
}
