using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RevolvingCredit.Data.DataFiltering;
using RevolvingCredit.UserControls;

namespace RevolvingCredit
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            RawData.LoadData();
            Application.Run(ServiceProvider.GetRequiredService<RevMain>());
        }
        public static IServiceProvider? ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddMemoryCache();
                    services.AddTransient<RevMain>();
                });
        }
    }
}