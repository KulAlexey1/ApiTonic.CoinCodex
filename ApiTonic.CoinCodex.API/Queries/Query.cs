using ApiTonic.CoinCodex.ClientLibrary.Models.Coin;
using ApiTonic.CoinCodex.ClientLibrary.Models.Prediction;
using ApiTonic.CoinCodex.ClientLibrary.Services;

namespace ApiTonic.API.Queries
{
    public class Query
    {
        public Task<Prediction> GetPredictionAsync(
            [Service] IPredictionService service,
            string shortName)
        {
            return service.GetAsync(shortName);
        }

        public Task<IEnumerable<Coin>> GetCoinsAsync([Service] ICoinService service)
        {
            return service.GetAllAsync();
        }
    }
}
