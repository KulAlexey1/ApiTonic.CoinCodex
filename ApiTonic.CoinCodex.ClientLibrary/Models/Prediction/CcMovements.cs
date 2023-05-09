namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcMovements
    {
        public Dictionary<int, CcMovement> EMA { get; set; }
        public Dictionary<int, CcMovement> SMA { get; set; }
    }
}
