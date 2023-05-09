using ApiTonic.CoinCodex.API.Queries;

namespace ApiTonic.API.Queries
{
    public class Query
    {
        public CoinCodexQuery CoinCodex { get; set; } = new CoinCodexQuery();
    }
}
