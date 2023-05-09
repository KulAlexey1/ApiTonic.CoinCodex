using ApiTonic.CoinCodex.ClientLibrary.Models.Coin;
using ApiTonic.CoinCodex.ClientLibrary.Models.Prediction;
using ApiTonic.CoinCodex.ClientLibrary.Services;

namespace ApiTonic.CoinCodex.API.Queries
{
    public class CoinCodexQuery
    {
        public Task<CcPrediction> GetPredictionAsync(
            [Service] IPredictionService service,
            string shortName)
        {
            return service.GetAsync(shortName);
        }

        public Task<IEnumerable<CcCoin>> GetCoinsAsync([Service] ICoinService service)
        {
            return service.GetAllAsync();
        }
    }
}
