using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Refit;
using ApiTonic.CoinCodex.ClientLibrary.Converters;

namespace ApiTonic.CoinCodex.ClientLibrary.Extensions
{
    public static class RefitExtensions
    {
        public static RefitSettings GetNewtonsoftJsonRefitSettings()
            => new RefitSettings(
                new NewtonsoftJsonContentSerializer(
                    new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver(),
                        Converters = { new SafeDateTimeConverter() }
                    })
               );
    }
}
