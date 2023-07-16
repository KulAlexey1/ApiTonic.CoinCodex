namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcGrowth
    {
        public CcWorldMoney worldMoney { get; set; }
        public CcAllTimeGrowth allTime { get; set; }
        public Dictionary<int?, double?> moore { get; set; }
        public Dictionary<int?, CcOtherGrowth> others { get; set; }
        public Dictionary<int?, CcBitcoinGrowth> bitcoin { get; set; }
        public CcAllTimeGrowth bitcoinAllTime { get; set; }
        public Dictionary<string, CcGrowthSource> sources { get; set; }
        public CcGrowthHistoricalData historical { get; set; }
    }
}
