using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model.Implementation
{
    public class Weather
    {
        [JsonProperty(PropertyName = "curren_weather")]
        public List<CurrentWeather> CurrentWeather { get; set; }
        [JsonProperty(PropertyName = "forecast")]
        public List<Forecast> Forecasts { get; set; }
    }
}
