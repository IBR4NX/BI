namespace Presentation;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        //var sw = Stopwatch.StartNew();
        //Debug.WriteLine($"\n [Startup] Begin ({DateTime.Now:O})");

        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();

        Application.Run(new MainForm());

        #region try 
        //try
        //{


        //    Debug.WriteLine($"\n [Startup] About to start Main form - Elapsed {sw.Elapsed}");
        //    Debug.WriteLine($"[Shutdown] Main form closed - Elapsed {sw.Elapsed}");
        //}
        //catch (Exception ex)
        //{
        //    Debug.WriteLine($"\n [Startup][Error] Exception during startup - Elapsed {sw.Elapsed}: {ex}");
        //    MessageBox.Show(
        //        $"Unable to load the database metadata.\\n\\n{ex.Message}",
        //        "Startup Error",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Error);
        //}
        //finally
        //{
        //    sw.Stop();
        //    Debug.WriteLine($"\n [Startup] Finished - Total Elapsed {sw.Elapsed}");
        //}
        #endregion
    }
}
