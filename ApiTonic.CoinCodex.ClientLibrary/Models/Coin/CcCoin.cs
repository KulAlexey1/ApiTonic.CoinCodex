namespace ApiTonic.CoinCodex.ClientLibrary.Models.Coin
{
    public class CcCoin
    {
        public int? market_cap_rank { get; set; }
        public string symbol { get; set; }
        public string display_symbol { get; set; }
        public string name { get; set; }
        public string display { get; set; }
        public double? last_price_usd { get; set; }
        public double volume_24_usd { get; set; }
        public double? last_market_cap_usd { get; set; }
        public double price_change_1H_percent { get; set; }
        public double price_change_1D_percent { get; set; }
        public double price_change_7D_percent { get; set; }
        public double price_change_30D_percent { get; set; }
        public double price_change_90D_percent { get; set; }
        public double price_change_180D_percent { get; set; }
        public double price_change_YTD_percent { get; set; }
        public double price_change_365D_percent { get; set; }
        public double price_change_3Y_percent { get; set; }
        public double price_change_5Y_percent { get; set; }
        public double price_change_ALL_percent { get; set; }
        public string ccu_slug { get; set; }
        public object supply { get; set; }
        public object total_supply { get; set; }
        public int? visits_24h_rank { get; set; }
        public string image_id { get; set; }
        public double btc_price { get; set; }
        public double btc_change { get; set; }
        public string shortname { get; set; }
        public string include_supply { get; set; }
        public int? trading_since { get; set; }
        public int? created { get; set; }
        public int image_t { get; set; }
        public double ath_usd { get; set; }
        public int? ath_date { get; set; }
        public int green_days { get; set; }
        public double? total_score { get; set; }
        public double? cmgr_3m { get; set; }
        public double? average_mktcap_all_time { get; set; }
        public double? growth_all_time { get; set; }
        public double? first_price_usd { get; set; }
        public int? coin_age { get; set; }
        public int? winning_months_trailing_12m { get; set; }
        public double score { get; set; }
    }
}
