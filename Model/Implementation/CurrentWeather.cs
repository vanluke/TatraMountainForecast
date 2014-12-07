using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
{
    [DataContract(Name = "curren_weather")]
    public class CurrentWeather
    {
        public CurrentWeather()
        {
            Winds = new List<Wind>();
        }
        [Key]
        public int Id { get; set; }
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
        public IEnumerable<Wind> Winds { get; set; }
    }
}
