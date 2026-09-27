using Domain.Interfaces;

namespace Domain.Settings;

public enum AuthenticationType
{
    Windows,
    SqlServer
}
public class ConnectionSettings : IConnectionSettings
{
    public string Server { get; set; }
    public int? Port { get; set; } = 1433;

    public string? Database { get; set; } = string.Empty;

    public AuthenticationType? Authentication { get; set; } = AuthenticationType.Windows;

    public string? Username { get; set; }

    public string? Password { get; set; }

}
public class ConnectionSettingsStatic 
{
    public static string Server { get; set; } = string.Empty;
    public static int? Port { get; set; } = 1433;

    public static string? Database { get; set; } = string.Empty;

    public static AuthenticationType? Authentication { get; set; } = AuthenticationType.Windows;

    public static string? Username { get; set; }

    public static string? Password { get; set; }

}
