using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Implementation;
using Newtonsoft.Json;

namespace Model.Interfaces
{
    public interface IWeather
    {
        [JsonProperty(PropertyName = "curren_weather")]
        IEnumerable<ICurrentWeather> CurrentWeather { get; }
        [JsonProperty(PropertyName = "forecast")]
        IEnumerable<IForecast> Forecasts { get; }

        string City { get; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        string Id { get; }
    }
}
