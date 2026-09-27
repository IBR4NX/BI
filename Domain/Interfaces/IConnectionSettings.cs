namespace Domain.Interfaces
{
    public interface IConnectionSettings
    {
        string Server { get; set; }

        int? Port { get; set; }

        string? Database { get; set; }

        string? Username { get; set; }

        string? Password { get; set; }

    }
}
