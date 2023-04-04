using Newtonsoft.Json;

namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class ChartData
    {
        [JsonProperty("30D")]
        public List<List<double>> _30D { get; set; }

        [JsonProperty("30D_5D")]
        public List<List<double>> _30D_5D { get; set; }

        [JsonProperty("180D")]
        public List<List<double>> _180D { get; set; }

        [JsonProperty("365D")]
        public List<List<double>> _365D { get; set; }

        [JsonProperty("2Y")]
        public List<List<double>> _2Y { get; set; }

        [JsonProperty("3Y")]
        public List<List<double>> _3Y { get; set; }
    }
}
