using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConsoleForAPI
{
  public class Root
  {
    public DateTime ap_time { get; set; }
    public DateTime block_time { get; set; }
  }

  public class _1d
  {
    public string volume { get; set; }
    public string price_change { get; set; }
    public string price_change_pct { get; set; }
    public string volume_change { get; set; }
    public string volume_change_pct { get; set; }
    public string market_cap_change { get; set; }
    public string market_cap_change_pct { get; set; }
  }

  public class _30d
  {
    public string volume { get; set; }
    public string price_change { get; set; }
    public string price_change_pct { get; set; }
    public string volume_change { get; set; }
    public string volume_change_pct { get; set; }
    public string market_cap_change { get; set; }
    public string market_cap_change_pct { get; set; }
  }

  public class Crypto
  {
    public string id { get; set; }
    public string currency { get; set; }
    public string symbol { get; set; }
    public string name { get; set; }
    public string logo_url { get; set; }
    public string status { get; set; }
    public string price { get; set; }
    public DateTime price_date { get; set; }
    public DateTime price_timestamp { get; set; }
    public string circulating_supply { get; set; }
    public string max_supply { get; set; }
    public string market_cap { get; set; }
    public string market_cap_dominance { get; set; }
    public string num_exchanges { get; set; }
    public string num_pairs { get; set; }
    public string num_pairs_unmapped { get; set; }
    public DateTime first_candle { get; set; }
    public DateTime first_trade { get; set; }
    public DateTime first_order_book { get; set; }
    public string rank { get; set; }
    public string rank_delta { get; set; }
    public string high { get; set; }
    public DateTime high_timestamp { get; set; }
    public _1d _1d { get; set; }
    public _30d _30d { get; set; }
  }

}
