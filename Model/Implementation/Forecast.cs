using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model.Implementation
{
    public class Forecast
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
        [JsonProperty(PropertyName = "day")]
        public List<Day> Days { get; set; }
        [JsonProperty(PropertyName = "day_max_temp")]
        public string DayMaxTemperature { get; set; }
        [JsonProperty(PropertyName = "night")]
        public List<Night> Nights { get; set; }
        [JsonProperty(PropertyName = "night_min_temp")]
        public string NightMinTemperature { get; set; }
        [JsonProperty(PropertyName = "temp_unit")]
        public string Unit { get; set; }
    }
}
