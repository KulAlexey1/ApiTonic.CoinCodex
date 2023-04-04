namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class QuarterlyPrediction
    {
        public List<List<double>> currentData { get; set; }
        public SimplePredictionData prediction { get; set; }
    }
}
