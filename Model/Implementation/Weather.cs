using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Model.Implementation
{
    public class Weather
    {
        public Weather(string city, List<CurrentWeather> currentWeather, List<Forecast> forecasts)
        {
            CurrentWeather = currentWeather;
            Forecasts = forecasts;
            City = city;
        }

        public Weather()
        {
            
        }

        [JsonProperty(PropertyName = "curren_weather")]
        public List<CurrentWeather> CurrentWeather { get; set; }
        [JsonProperty(PropertyName = "forecast")]
        public List<Forecast> Forecasts { get; set; }

        public string City { get; set; }

        [Key]
        public string Id { get; set; }
    }
}
