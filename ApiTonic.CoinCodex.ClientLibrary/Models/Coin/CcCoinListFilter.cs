namespace ApiTonic.CoinCodex.ClientLibrary.Models.Coin
{
    public class CcCoinListFilter
    {
        public List<string> type { get; set; }
        public bool select_byslug { get; set; }
        public bool select_bysymbol { get; set; }
        public string order_by { get; set; }
        public string order_direction { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public bool categories { get; set; }
        public bool exchanges { get; set; }
        public bool display { get; set; }
        public List<string> include { get; set; }
        public CcCoinListFilterMinMax minmax { get; set; }
    }
}
