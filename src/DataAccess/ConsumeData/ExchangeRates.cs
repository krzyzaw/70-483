using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataAccess.ConsumeData
{
    public class ExchangeRates
    {
        [JsonProperty("table")]
        public string Table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public List<Rate> rates { get; set; }
    }
}