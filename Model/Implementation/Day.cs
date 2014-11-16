using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model.Implementation
{
    public class Day
    {
        [JsonProperty(PropertyName = "weather_code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "weather_text")]
        public string Comments { get; set; }
        [JsonProperty(PropertyName = "wind")]
        public List<ExtenedWind> Winds { get; set; }
    }
}
