namespace ApiTonic.CoinCodex.ClientLibrary.Models.Coin
{
    public class CcCoinListResult
    {
        public CcCoinListMeta meta { get; set; }
        public List<CcCoin> data { get; set; }
    }
}
