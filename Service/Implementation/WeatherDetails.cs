using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Service.Implementation
{
    [DataContract(Name = "main")]
    public class WeatherDetails : IWeatherDetails
    {
        [JsonProperty(PropertyName = "temp")]
        public double Temperature { get; set; }

        [JsonProperty(PropertyName = "temp_min")]
        public double MinTemperature { get; set; }

        [JsonProperty(PropertyName = "temp_max")]
        public double MaxTemperature { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public double Pressure { get; set; }

        [JsonProperty(PropertyName = "sea_level")]
        public double SeaLevel { get; set; }

        [JsonProperty(PropertyName = "grnd_level")]
        public double GroundLevel { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public double Humidity { get; set; }
    }
}
