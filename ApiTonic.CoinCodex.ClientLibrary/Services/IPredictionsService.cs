using ApiTonic.CoinCodex.ClientLibrary.Models.Prediction;
using Refit;

namespace ApiTonic.CoinCodex.ClientLibrary.Services
{
    public interface IPredictionsService
    {
        [Get("/predictions/get_byshortname/{shortname}")]
        Task<Prediction> GetAsync(string shortName);
    }
}
