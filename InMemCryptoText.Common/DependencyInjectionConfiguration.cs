using CryptoLib;
using Microsoft.Extensions.DependencyInjection;

namespace InMemCryptoText.Common
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services, CryptoOptions options)
        {
            services.AddTransient<CryptoOptions>(f => options);
            services.AddTransient<GenericCrypto>();
            services.AddScoped<ICryptography, Cryptography>();
            return services;
        }
    }
}
