using System.Collections.Generic;
using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Service.Implementation
{
    [DataContract(Name = "list")]
    public class Forecast : IForecast
    {
        public Forecast()
        {
            Coordinate = new Possition();
            WeatherDetails = new WeatherDetails();
            Wind = new Wind();
            Clouds = new Clouds();
            Weather = new List<Weather>();
            Rain = new Rain();
            Snow = new Snow();
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "coord")]
        public IPossition Coordinate { get; set; }

        [JsonProperty(PropertyName = "main")]
        public IWeatherDetails WeatherDetails { get; set; }

        [JsonProperty(PropertyName = "dt")]
        public int DataReceivingTime { get; set; }

        [JsonProperty(PropertyName = "wind")]
        public IWind Wind { get; set; }

        [JsonProperty(PropertyName = "clouds")]
        public IClouds Clouds { get; set; }

        [JsonProperty(PropertyName = "weather")]
        public IEnumerable<IWeather> Weather { get; set; }

        [JsonProperty(PropertyName = "rain")]
        public IRain Rain { get; set; }

        [JsonProperty(PropertyName = "snow")]
        public ISnow Snow { get; set; }
    }

}
