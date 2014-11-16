using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Models
{
    public class Wind
    {
        [JsonProperty(PropertyName = "dir")]
        public string Dirrection { get; set; }
        [JsonProperty(PropertyName = "speed")]
        public string Speed { get; set; }
        [JsonProperty(PropertyName = "wind_unit")]
        public string Unit { get; set; }
    }
    [DataContract(Name = "CurrenWeather")]
    public class CurrentWeather
    {
        [JsonProperty(PropertyName = "humidity")]
        public string Humidity { get; set; }
        [JsonProperty(PropertyName = "pressure")]
        public string Pressure { get; set; }
        [JsonProperty(PropertyName = "temp")]
        public string Temperature { get; set; }
        [JsonProperty(PropertyName = "temp_unit")]
        public string TemperatureUnit { get; set; }
        [JsonProperty(PropertyName = "weather_code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "weather_text")]
        public string Comments { get; set; }
        [JsonProperty(PropertyName = "wind")]
        public List<Wind> Winds { get; set; }
    }
    [DataContract(Name = "wind2")]
    public class ExtenedWind : Wind
    {
        [JsonProperty(PropertyName = "dir_degree")]
        public string Degree { get; set; }
    }

    public class Day
    {
        [JsonProperty(PropertyName = "weather_code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "weather_text")]
        public string Comments { get; set; }
        [JsonProperty(PropertyName = "wind")]
        public List<ExtenedWind> Winds { get; set; }
    }
    public class Night
    {
        [JsonProperty(PropertyName = "weather_code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "weather_text")]
        public string Comments { get; set; }
        [JsonProperty(PropertyName = "wind")]
        public List<ExtenedWind> wind { get; set; }
    }

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

    public class Weather
    {
        [JsonProperty(PropertyName = "curren_weather")]
        public List<CurrentWeather> CurrentWeather { get; set; }
        [JsonProperty(PropertyName = "forecast")]
        public List<Forecast> Forecasts { get; set; }
    }

    public class Wether
    {
        [JsonProperty(PropertyName = "weather")]
        public Weather Weather { get; set; }
    }
}