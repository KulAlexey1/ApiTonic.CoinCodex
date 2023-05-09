namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcGreedFear
    {
        public int value { get; set; }
        public string value_classification { get; set; }
        public int timestamp { get; set; }
        public int time_until_update { get; set; }
    }
}
