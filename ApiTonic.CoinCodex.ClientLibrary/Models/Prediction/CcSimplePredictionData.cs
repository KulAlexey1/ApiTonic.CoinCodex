namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcSimplePredictionData
    {
        public List<List<double>> bullish { get; set; }
        public List<List<double>> bearish { get; set; }
        public List<List<double>> average { get; set; }
    }
}
