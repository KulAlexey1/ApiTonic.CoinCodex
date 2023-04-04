namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class Movements
    {
        public Dictionary<int, Movement> EMA { get; set; }
        public Dictionary<int, Movement> SMA { get; set; }
    }
}
