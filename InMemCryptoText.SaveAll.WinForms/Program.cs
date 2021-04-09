using CryptoLib;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace InMemCryptoText.SaveAll.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            Application.Run(new frmMain());
        }

        static void ConfigureServices(ServiceCollection services)
        {
            var iterations = Convert.ToInt32(ConfigurationManager.AppSettings["Iterations"]);
            var keySize = Convert.ToInt32(ConfigurationManager.AppSettings["KeySize"]);
            var hash = ConfigurationManager.AppSettings["Hash"];
            var salt = ConfigurationManager.AppSettings["Salt"];
            var vector = ConfigurationManager.AppSettings["Vector"];

            var options = new CryptoOptions
            {
                Iterations = iterations,
                KeySize = keySize,
                Hash = hash,
                Salt = salt,
                Vector = vector
            };

            services.AddTransient<CryptoOptions>(f=>options);
            services.AddTransient<GenericCrypto>();
            services.AddScoped<ICryptography, Cryptography>();
        }
    }
}
