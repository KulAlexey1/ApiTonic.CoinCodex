using Newtonsoft.Json;

namespace ApiTonic.CoinCodex.ClientLibrary.Models.Coin
{
    public class CcCoinListFilterMinMax
    {
        public bool circulating_supply { get; set; }
        public bool total_supply { get; set; }
        public bool market_cap { get; set; }
        public bool volume { get; set; }
        public bool score { get; set; }
        public bool age_months { get; set; }
        public bool winning_months { get; set; }

        [JsonProperty("30day_volatility")]
        public bool _30day_volatility { get; set; }
        public bool growth { get; set; }
        public bool roi { get; set; }
        public bool market_cap_rank { get; set; }
    }
}
