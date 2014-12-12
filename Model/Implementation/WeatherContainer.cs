using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
{
    public class WeatherContainer : IWeatherContainer
    {
        public WeatherContainer()
        {
            Forecast = new List<Forecast>();
        }

        [NotMapped]
        [JsonProperty(PropertyName = "cod")]
        public string Cod { get; set; }

        [NotMapped]
        [JsonProperty(PropertyName = "calctime")]
        public double Calctime { get; set; }

        [NotMapped]
        [JsonProperty(PropertyName = "cnt")]
        public int NumberOfLinesReturnedByApiCall { get; set; }

        [NotMapped]
        [JsonProperty(PropertyName = "list")]
        public IEnumerable<IForecast> Forecast { get; set; }

        public string All { get { return SerilizeToJson(); } private set { if (value != null) Forecast = DeserializeToIForecast(value); } }

        private string SerilizeToJson()
        {
            var json = JsonConvert.SerializeObject(Forecast);
            return json;
        }

        private IEnumerable<IForecast> DeserializeToIForecast(string data)
        {
            var toObject = JsonConvert.DeserializeObject<IEnumerable<Forecast>>(data);
            return toObject;
        }

        [Key]
        public int Id { get; set; }
    }
}
