using CryptoLib;
using InMemCryptoText.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace XUnitTests.Config
{
    public abstract class BaseConfigSetup
    {
        protected IConfiguration Configuration;
        protected readonly IServiceProvider ServiceProvider;

        public BaseConfigSetup()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var settings = Configuration.GetSection("CryptoOptions").Get<CryptoOptions>();

            services.AddServices(settings);
        }
    }
}
