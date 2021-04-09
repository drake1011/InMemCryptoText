using CryptoLib;
using InMemCryptoText.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InMemCryptoText.WinFormsCore
{
    static class Program
    {
        public static IConfiguration Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frm = serviceProvider.GetRequiredService<frmMain>();
                Application.Run(frm);
            }
        }

        static void ConfigureServices(ServiceCollection services)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var settings = Configuration.GetSection("CryptoOptions").Get<CryptoOptions>();

            services.AddServices(settings);
            services.AddTransient<frmMain>();
            services.AddTransient<frmStyleConfig>();
        }
    }
}
