using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model.Implementation
{
     [DataContract(Name = "forecast")]
    public class Forecast
    {
        public Forecast()
        {
            Days = new List<Day>();
            Nights = new List<Night>();
        }
        [Key]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
        [JsonProperty(PropertyName = "day")]
        public IEnumerable<Day> Days { get; set; }
        [JsonProperty(PropertyName = "day_max_temp")]
        public string DayMaxTemperature { get; set; }
        [JsonProperty(PropertyName = "night")]
        public IEnumerable<Night> Nights { get; set; }
        [JsonProperty(PropertyName = "night_min_temp")]
        public string NightMinTemperature { get; set; }
        [JsonProperty(PropertyName = "temp_unit")]
        public string Unit { get; set; }
    }
}
