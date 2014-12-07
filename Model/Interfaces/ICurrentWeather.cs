using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Implementation;
using Newtonsoft.Json;

namespace Model.Interfaces
{
    public interface ICurrentWeather
    {
        [Key]
        int Id { get; set; }
        [JsonProperty(PropertyName = "humidity")]
        string Humidity { get; set; }
        [JsonProperty(PropertyName = "pressure")]
        string Pressure { get; set; }
        [JsonProperty(PropertyName = "temp")]
        string Temperature { get; set; }
        [JsonProperty(PropertyName = "temp_unit")]
        string TemperatureUnit { get; set; }
        [JsonProperty(PropertyName = "weather_code")]
        string Code { get; set; }
        [JsonProperty(PropertyName = "weather_text")]
        string Comments { get; set; }
        [JsonProperty(PropertyName = "wind")]
        [JsonConverter(typeof(ConcreteTypeConverter<List<Wind>>))]
        IEnumerable<IWind> Winds { get; set; }
    }
}
