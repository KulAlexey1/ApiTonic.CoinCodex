using ApiTonic.CoinCodex.ClientLibrary.Models.Coin;
using ApiTonic.CoinCodex.ClientLibrary.Models.Prediction;
using ApiTonic.CoinCodex.ClientLibrary.Services;

namespace ApiTonic.CoinCodex.API.Queries
{
    public class CoinCodexQuery
    {
        public async Task<CcPrediction> GetPredictionAsync(
            [Service] IPredictionService service,
            string shortname)
        {
            try
            {
                return await service.GetAsync(shortname);
            }
            catch (Exception ex)
            {
                var t = 1;
                throw ex;
            }
        }

        //public async Task<IEnumerable<CcCoin>> GetCoinsAsync([Service] ICoinService service)
        //{
        //    var coins = await service.GetAllAsync();
        //    return coins.Take(50);
        //}

        public async Task<CcCoinListResult> GetCoinListAsync([Service] ICoinService service)
        {
            try
            {
                var result = await service.GetCoinListAsync();
                return result;
            }
            catch(Exception ex)
            {
                var t = 1;
                throw ex;
            }
        }
    }
}
