using DataAccess.Factory;
using DataAccess.SqlServer;
using Domain.Settings;
using Domain.Configuration;

using Microsoft.Data.SqlClient;
using System.Data;
using Presentation.Forms.Base;
namespace Presentation;

public partial class Login : BaseForm
{
    private ConnectionSettingsStore store = new ConnectionSettingsStore(AppPaths.ConnectionsFile);

    public IDbProviderFactory? providerFactory { get; private set; }

    public Login()
    {
        InitializeComponent();
    }

    private void Login_Load(object? sender, EventArgs e)
    {
        ConnectionSettingsCollection settings = store.Load();

        foreach (ConnectionSettings connection in settings.Connections)
        {
            if (!string.IsNullOrWhiteSpace(connection.Server) &&
                !CmBxServer.Items.Contains(connection.Server))
            {
                CmBxServer.Items.Add(connection.Server);
            }
        }

        if (settings.Connections.Count > 0)
        {
            var last = settings.Connections[^1];

            CmBxServer.SelectedText = last.Server;

            CmbxAuthentication.SelectedIndex =
                last.Authentication == AuthenticationType.SqlServer ? 1 : 0;

            TxtUsername.Text = last.Username ?? string.Empty;
        }

        UpdateAuthenticationState();
        CmbxAuthentication.SelectedIndex = 0;
        cmbTypeDB.SelectedIndex = 0;
        CmBxServer.Focus();
    }

    private void CmbxAuthentication_SelectedIndexChanged(object? sender, EventArgs e)
    {
        UpdateAuthenticationState();

    }
    private void UpdateAuthenticationState()
    {
        bool sqlAuthentication = CmbxAuthentication.SelectedIndex == 1;

        TxtUsername.Enabled = sqlAuthentication;
        TxtPassword.Enabled = sqlAuthentication;
        LblUsername.Enabled = sqlAuthentication;
        LblPassword.Enabled = sqlAuthentication;

        if (!sqlAuthentication)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
        }
    }

    private async void BtnLogin_Click(object? sender, EventArgs e)
    {
        string server = CmBxServer.Text.Trim();
        string Username = TxtUsername.Text.Trim();
        string Password = TxtPassword.Text.Trim();
        bool sqlAuthentication = CmbxAuthentication.SelectedIndex == 1;

        if (string.IsNullOrWhiteSpace(server))
        {
            Helper.Show("Please enter the SQL Server name.");
            CmBxServer.Focus();
            return;
        }

        if (sqlAuthentication && string.IsNullOrWhiteSpace(Username))
        {
            Helper.Show("Please enter the username.");
            TxtUsername.Focus();
            return;
        }

        if (sqlAuthentication && string.IsNullOrWhiteSpace(Password))
        {
            Helper.Show("Please enter the password.");
            TxtPassword.Focus();
            return;
        }

        try
        {
            BtnLogin.Enabled = false;
            BtnLogin.Text = "Connecting...";
            if (cmbTypeDB.SelectedItem?.ToString() == "sqlServer")
            {
                providerFactory = new SqlServerDatabaseProviderFactory();
                providerFactory.ConnectionStringBuilder.ConnectionSettings.Server = server;
                providerFactory.ReBuild(providerFactory.ConnectionStringBuilder.Build());
                providerFactory.ConnectionFactory.ConnectionOpened();
                SaveConnection(server, "", sqlAuthentication);
                await GetData();
                DialogResult = DialogResult.OK;

            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show(
                $"Could not connect to the database.\\n\\n{ex.Message}",
                "Connection Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex+
                ex.HelpLink,
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            if (!IsDisposed)
            {
                BtnLogin.Enabled = true;
                BtnLogin.Text = "Connect";
            }
        }
    }
    public async Task GetData()
    {
        await Task.Delay(2000);

        Console.WriteLine("Done");

    }
    private void SaveConnection(
        string server,
        string database,
        bool sqlAuthentication)
    {

        store.Save(new ConnectionSettings
        {
            Server = server,
            Database = database,
            Authentication = sqlAuthentication
                ? AuthenticationType.SqlServer
                : AuthenticationType.Windows,
            Username = sqlAuthentication ? TxtUsername.Text.Trim() : null
        });
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        //if (MessageBox.Show("do you want to exit from Application?  ", "Application exit", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
        //{
        //Application.Exit();
        //}
        //return;

    }

    private void CmBxServer_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void LblTitle_Click(object sender, EventArgs e)
    {

    }
}