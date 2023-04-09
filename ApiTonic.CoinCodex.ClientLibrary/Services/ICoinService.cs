using ApiTonic.CoinCodex.ClientLibrary.Models.Coin;
using Refit;

namespace ApiTonic.CoinCodex.ClientLibrary.Services
{
    public interface ICoinService
    {
        [Get("/apps/coincodex/cache/all_coins.json")]
        Task<IEnumerable<Coin>> GetAllAsync();
    }
}
