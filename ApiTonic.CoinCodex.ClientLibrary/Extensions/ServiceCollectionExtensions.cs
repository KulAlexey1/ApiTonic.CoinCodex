using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;
using ApiTonic.CoinCodex.ClientLibrary.Services;
using ApiTonic.CoinCodex.ClientLibrary.Models;

namespace ApiTonic.CoinCodex.ClientLibrary.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddClientLibraryServices(this IServiceCollection services)
        {
            services.AddCoinCodexService<IPredictionService>();
            services.AddCoinCodexService<ICoinService>();
        }

        private static void AddCoinCodexService<T>(this IServiceCollection services) where T : class
        {
            services.AddRefitClient<T>(RefitExtensions.GetNewtonsoftJsonRefitSettings())
                .ConfigureHttpClient((serviceProvider, client) =>
                {
                    var apiSettings = serviceProvider.GetRequiredService<IOptions<ApiSettings>>().Value;

                    client.BaseAddress = new Uri(apiSettings.BaseAddress);

                    if (apiSettings.HeaderApiKey != null && apiSettings.ApiKey != null)
                    {
                        client.DefaultRequestHeaders.Add(apiSettings.HeaderApiKey, apiSettings.ApiKey);
                    }
                });
        }
    }
}
