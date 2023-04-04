using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;
using ApiTonic.CoinCodex.ClientLibrary.Models.Prediction;
using ApiTonic.CoinCodex.ClientLibrary.Services;

namespace ApiTonic.CoinCodex.ClientLibrary
{
    public static class ServiceCollectionExtensions
    {
        public static void AddClientLibraryServices(this IServiceCollection services)
        {
            services.AddRefitClient<IPredictionsService>(RefitExtensions.GetNewtonsoftJsonRefitSettings())
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
