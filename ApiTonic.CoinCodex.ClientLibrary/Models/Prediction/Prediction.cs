namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class Prediction
    {
        public Movements movements { get; set; }
        public RSI RSI { get; set; }
        public double average_gain { get; set; }
        public double average_loss { get; set; }
        public int better_performance { get; set; }
        public int worse_performance { get; set; }
        public SupportsResisstances supports_resisstances { get; set; }
        public List<PearsonsConnotation> pearsons_positive { get; set; }
        public List<PearsonsConnotation> pearsons_negative { get; set; }
        public int generated_time { get; set; }
        public List<PearsonsCorrelationCoefficient> pearsons_correlation_coefficients { get; set; }
        public Oscilators oscilators { get; set; }
        public GreedFear greedFear { get; set; }
        public double volatility { get; set; }
        public GreenDays greenDays { get; set; }
        public List<List<double>> thirtyDayPrediction { get; set; }
        public ChartData predictionChart { get; set; }
        public ChartData currentChartData { get; set; }
        public ChartData movingAverageChart { get; set; }
        public List<List<double>> movingAveragePredictionChart { get; set; }
        public GlobalMarkets getGlobalMarkets { get; set; }
        public Growth growth { get; set; }
        public Dictionary<int, QuarterlyPrediction> quarterlyPrediction { get; set; }
    }
}
