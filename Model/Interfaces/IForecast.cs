using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model.Interfaces
{
    public interface IForecast
    {
        int Id { get; }
        string Name { get;  }
        IPossition Coordinate { get; }
        IWeatherDetails WeatherDetails { get; }
        int DataReceivingTime { get; }
        IWind Wind { get;  }
        IClouds Clouds { get; }
        IEnumerable<IWeather> Weather { get; }
        IRain Rain { get; }
        ISnow Snow { get; }
        //[Key]
        //int Id { get; set; }
        //[JsonProperty(PropertyName = "date")]
        //string Date { get; set; }
        //[JsonProperty(PropertyName = "day")]
        //IEnumerable<IDay> Days { get; set; }
        //[JsonProperty(PropertyName = "day_max_temp")]
        //string DayMaxTemperature { get; set; }
        //[JsonProperty(PropertyName = "night")]
        //IEnumerable<INight> Nights { get; set; }
        //[JsonProperty(PropertyName = "night_min_temp")]
        //string NightMinTemperature { get; set; }
        //[JsonProperty(PropertyName = "temp_unit")]
        //string Unit { get; set; }
    }
}
