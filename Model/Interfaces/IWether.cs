using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IWether
    {

    }

    public interface IWind
    {
        string Direction { get; set; }
        string Speed { get; set; }
        string WindUnit { get; set; }
    }
    public class Wind : IWind
    {
        public string Direction { get; set; }

        public string Speed { get; set; }

        public string WindUnit { get; set; }
    }

    public interface ICurrnetWeather
    {
        string Humidity { get; set; }
        string Pressure { get; set; }
        string Temperature { get; set; }
        string TemperatureUnit { get; set; }
        string WeatheCode { get; set; }
        string WeatherText { get; set; }
        List<Wind> Winds { get; set; }
    }
    public class CurrenWeather : ICurrnetWeather
    {

        public string Humidity { get; set; }

        public string Pressure { get; set; }

        public string Temperature { get; set; }

        public string TemperatureUnit { get; set; }

        public string WeatheCode { get; set; }

        public string WeatherText { get; set; }

        public List<Wind> Winds { get; set; }
    }

    public interface IWind2 : IWind
    {
        string DirrectionDegree { get; set; }
    }
    public class Wind2 : IWind2
    {
        public string DirrectionDegree
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Direction
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Speed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string WindUnit
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    public class Day
    {
        public string WeatherCode { get; set; }
        public string weather_text { get; set; }
        public List<Wind2> wind { get; set; }
    }

    public class Wind3
    {
        public string dir { get; set; }
        public string dir_degree { get; set; }
        public string speed { get; set; }
        public string wind_unit { get; set; }
    }

    public class Night
    {
        public string weather_code { get; set; }
        public string weather_text { get; set; }
        public List<Wind3> wind { get; set; }
    }

    public class Forecast
    {
        public string date { get; set; }
        public List<Day> day { get; set; }
        public string day_max_temp { get; set; }
        public List<Night> night { get; set; }
        public string night_min_temp { get; set; }
        public string temp_unit { get; set; }
    }

    public class Weather
    {
        public List<CurrenWeather> curren_weather { get; set; }
        public List<Forecast> forecast { get; set; }
    }

    public class RootObject
    {
        public Weather weather { get; set; }
    }
}
