namespace ApiTonic.CoinCodex.ClientLibrary.Models.Coin
{
    public class CcCoin
    {
        public string symbol { get; set; }
        public string display_symbol { get; set; }
        public string name { get; set; }
        public string aliases { get; set; }
        public string shortname { get; set; }
        public double? last_price_usd { get; set; }
        public long? market_cap_rank { get; set; }
        public long? volume_rank { get; set; }
        public double? price_change_1H_percent { get; set; }
        public double? price_change_1D_percent { get; set; }
        public double? price_change_7D_percent { get; set; }
        public double? price_change_30D_percent { get; set; }
        public double? price_change_90D_percent { get; set; }
        public double? price_change_180D_percent { get; set; }
        public double? price_change_365D_percent { get; set; }
        public double? price_change_3Y_percent { get; set; }
        public double? price_change_5Y_percent { get; set; }
        public double? price_change_ALL_percent { get; set; }
        public double? price_change_YTD_percent { get; set; }
        public double? volume_24_usd { get; set; }
        public string display { get; set; }
        public DateTimeOffset? trading_since { get; set; }
        public double? supply { get; set; }
        public long last_update { get; set; }
        public DateTimeOffset? ico_end { get; set; }
        public bool include_supply { get; set; }
        public bool use_volume { get; set; }
        public string growth_all_time { get; set; }
        public string ccu_slug { get; set; }
        public Guid? image_id { get; set; }
        public long? image_t { get; set; }
        public double market_cap_usd { get; set; }
        public List<long> categories { get; set; }
    }
}
