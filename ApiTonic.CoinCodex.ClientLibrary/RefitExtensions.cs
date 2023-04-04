using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Refit;

namespace ApiTonic.CoinCodex.ClientLibrary
{
    public static class RefitExtensions
    {
        public static RefitSettings GetNewtonsoftJsonRefitSettings()
            => new RefitSettings(
                new NewtonsoftJsonContentSerializer(
                    new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    })
               );
    }
}
