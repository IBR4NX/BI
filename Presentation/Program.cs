using Business.Metadata;
using DataAccess;
using System.Diagnostics;

namespace Presentation;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var sw = Stopwatch.StartNew();
        Debug.WriteLine($"\n [Startup] Begin ({DateTime.Now:O})");

        ApplicationConfiguration.Initialize();
        //Debug.WriteLine($"\n [Startup] After ApplicationConfiguration.Initialize - Elapsed {sw.Elapsed}");

        //using var login = new Login(); 
        //Debug.WriteLine($"\n [Startup] Showing Login dialog - Elapsed {sw.Elapsed}");
        //Debug.WriteLine(nameof(login));
        //if (login.ShowDialog() != DialogResult.OK)
        //{
        //    Debug.WriteLine($"\n [Startup] Login canceled or failed - Elapsed {sw.Elapsed}");
        //    sw.Stop();
        //    Debug.WriteLine($"\n [Startup] Exit before main window - Total Elapsed {sw.Elapsed}");
        //    return;
        //}
        //Debug.WriteLine($"\n [Startup] Login accepted - Elapsed {sw.Elapsed}");

        //var databaseRepository = new DatabaseRepository(login.Connection);
        //Debug.WriteLine($"\n [Startup] Created DatabaseRepository - Elapsed {sw.Elapsed}");

        //var metadataService = new MetadataService(databaseRepository);
        //Debug.WriteLine($"\n [Startup] Created MetadataService - Elapsed {sw.Elapsed}");

        //Debug.WriteLine($"\n [Startup] End metadataService.Load - Elapsed {sw.Elapsed}");

        //var dataRepository = new DataRepository(login.Connection);
        //Debug.WriteLine($"\n [Startup] Created DataRepository - Elapsed {sw.Elapsed}");

        //var validator = new QueryValidator(metadataService.Metadata);
        //Debug.WriteLine($"\n [Startup] Created QueryValidator - Elapsed {sw.Elapsed}");

        try
        {
            //var queryBuilder = new QueryBuilder();
            //Debug.WriteLine($"\n [Startup] Created QueryBuilder - Elapsed {sw.Elapsed}");

            //var queryService = new QueryService(
            //    dataRepository,
            //    queryBuilder,
            //    validator);
            //Debug.WriteLine($"\n [Startup] Created QueryService - Elapsed {sw.Elapsed}");

            Debug.WriteLine($"\n [Startup] About to start Main form - Elapsed {sw.Elapsed}");
            Application.Run(new Main());
            Debug.WriteLine($"[Shutdown] Main form closed - Elapsed {sw.Elapsed}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"\n [Startup][Error] Exception during startup - Elapsed {sw.Elapsed}: {ex}");
            MessageBox.Show(
                $"Unable to load the database metadata.\\n\\n{ex.Message}",
                "Startup Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            sw.Stop();
            Debug.WriteLine($"\n [Startup] Finished - Total Elapsed {sw.Elapsed}");
        }
    }
}

//namespace Presentation
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
//            Application.Run(new Login());
//        }
//    }
//}