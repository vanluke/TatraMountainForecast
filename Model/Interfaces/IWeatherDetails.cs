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
    //[JsonProperty(PropertyName = "curren_weather")]
    public interface IWeatherDetails
    {
        double Temperature { get; set; }
        double MinTemperature { get; set; }
        double MaxTemperature { get; set; }
        double Pressure { get; set; }
        double SeaLevel { get; set; }
        double GroundLevel { get; set; }
        double Humidity { get; set; }
        //[JsonProperty(PropertyName = "curren_weather")]
        //IEnumerable<ICurrentWeather> CurrentWeather { get; }
        //[JsonProperty(PropertyName = "forecast")]
        //IEnumerable<IForecast> Forecasts { get; }

        //string City { get; }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //string Id { get; }
    }
}
