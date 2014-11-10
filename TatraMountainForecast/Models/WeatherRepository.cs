using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatraMountainForecast.Models
{
    public class WeatherRepository
    {
        public static IEnumerable<Weather> CreateWeatherList()
        {
            var data = new[]
            {
                new Weather(){ Comments = "Rainy all day", Id = 1, Temperature = "21", Unit = "Celcious"},
                new Weather(){ Comments = "Sunny all day", Id = 2, Temperature = "31", Unit = "Celcious"},
                new Weather(){ Comments = "Fog", Id = 3, Temperature = "11", Unit = "Celcious"},
                new Weather(){ Comments = "Cloudy", Id = 4, Temperature = "21", Unit = "Celcious"},
                new Weather(){ Comments = "Cool", Id = 5, Temperature = "21", Unit = "Celcious"},
            };
            return data;
        }
    }
}