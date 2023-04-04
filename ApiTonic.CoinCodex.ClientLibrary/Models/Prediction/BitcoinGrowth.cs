using Newtonsoft.Json;

namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class BitcoinGrowth
    {
        [JsonProperty("1")]
        public double _1 { get; set; }

        [JsonProperty("2")]
        public double _2 { get; set; }

        [JsonProperty("5")]
        public double _5 { get; set; }

        [JsonProperty("10")]
        public double _10 { get; set; }

        [JsonProperty("20")]
        public double _20 { get; set; }

        [JsonProperty("50")]
        public double _50 { get; set; }

        [JsonProperty("100")]
        public double _100 { get; set; }
    }
}
