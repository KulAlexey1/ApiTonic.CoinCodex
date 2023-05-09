namespace ApiTonic.CoinCodex.ClientLibrary.Models.Prediction
{
    public class CcAllTimeGrowth
    {
        public double avg_yearly_growth_all_time { get; set; }
        public CcDatePrice start { get; set; }
        public CcDatePrice end { get; set; }
    }
}
