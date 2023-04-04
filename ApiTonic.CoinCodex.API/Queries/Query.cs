﻿using ApiTonic.CoinCodex.ClientLibrary.Models.Prediction;
using ApiTonic.CoinCodex.ClientLibrary.Services;

namespace ApiTonic.API.Queries
{
    public class Query
    {
        public Task<Prediction> GetPredictionAsync(
            [Service] IPredictionsService service,
            string shortName)
        {
            return service.GetAsync(shortName);
        }
    }
}