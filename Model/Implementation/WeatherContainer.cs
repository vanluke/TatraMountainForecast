using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [JsonProperty(PropertyName = "cod")]
        public string Cod { get; set; }

        [JsonProperty(PropertyName = "calctime")]
        public double Calctime { get; set; }

        [JsonProperty(PropertyName = "cnt")]
        public int NumberOfLinesReturnedByApiCall { get; set; }

        [JsonProperty(PropertyName = "list")]
        public IEnumerable<IForecast> Forecast { get; set; }
    }
}
