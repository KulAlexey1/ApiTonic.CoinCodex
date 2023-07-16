namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcQuarterlyPrediction
    {
        public List<List<double?>> currentData { get; set; }
        public CcSimplePredictionData prediction { get; set; }
    }
}
