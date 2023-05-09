namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcPrediction
    {
        public CcMovements movements { get; set; }
        public CcRSI RSI { get; set; }
        public double average_gain { get; set; }
        public double average_loss { get; set; }
        public int better_performance { get; set; }
        public int worse_performance { get; set; }
        public CcSupportsResisstances supports_resisstances { get; set; }
        public List<CcPearsonsConnotation> pearsons_positive { get; set; }
        public List<CcPearsonsConnotation> pearsons_negative { get; set; }
        public int generated_time { get; set; }
        public List<CcPearsonsCorrelationCoefficient> pearsons_correlation_coefficients { get; set; }
        public CcOscilators oscilators { get; set; }
        public CcGreedFear greedFear { get; set; }
        public double volatility { get; set; }
        public CcGreenDays greenDays { get; set; }
        public List<List<double>> thirtyDayPrediction { get; set; }
        public CcChartData predictionChart { get; set; }
        public CcChartData currentChartData { get; set; }
        public CcChartData movingAverageChart { get; set; }
        public List<List<double>> movingAveragePredictionChart { get; set; }
        public CcGlobalMarkets getGlobalMarkets { get; set; }
        public CcGrowth growth { get; set; }
        public Dictionary<int, CcQuarterlyPrediction> quarterlyPrediction { get; set; }
    }
}
