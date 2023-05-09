using Newtonsoft.Json;

namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcPercent
    {
        [JsonProperty("1")]
        public double _1 { get; set; }

        [JsonProperty("2")]
        public double _2 { get; set; }

        [JsonProperty("4")]
        public double _4 { get; set; }

        [JsonProperty("8")]
        public double _8 { get; set; }

        [JsonProperty("16")]
        public double _16 { get; set; }

        [JsonProperty("32")]
        public double _32 { get; set; }
    }
}
