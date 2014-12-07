using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Interfaces;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Model.Implementation
{
    [DataContract(Name = "weather")]
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
            CurrentWeather = new List<CurrentWeather>();
            Forecasts = new List<Forecast>();
        }

        [JsonProperty(PropertyName = "curren_weather")]
        public IEnumerable<CurrentWeather> CurrentWeather { get; set; }
        [JsonProperty(PropertyName = "forecast")]
        public IEnumerable<Forecast> Forecasts { get; set; }

        public string City { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
    }
}
