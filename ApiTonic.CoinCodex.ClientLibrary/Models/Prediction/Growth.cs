namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class Growth
    {
        public WorldMoney worldMoney { get; set; }
        public AllTimeGrowth allTime { get; set; }
        public Dictionary<int, double> moore { get; set; }
        public Dictionary<int, OtherGrowth> others { get; set; }
        public Dictionary<int, BitcoinGrowth> bitcoin { get; set; }
        public AllTimeGrowth bitcoinAllTime { get; set; }
        public Dictionary<string, GrowthSource> sources { get; set; }
        public GrowthHistoricalData historical { get; set; }
    }
}
