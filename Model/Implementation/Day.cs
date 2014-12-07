using System.Collections.Generic;
using Model.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Model.Implementation
{
     [DataContract(Name = "day")]
    public class Day
    {
        public Day()
        {
            Winds = new List<ExtendedWind>();
        }
        [Key]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "weather_code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "weather_text")]
        public string Comments { get; set; }
        [JsonProperty(PropertyName = "wind")]
        public IEnumerable<ExtendedWind> Winds { get; set; }
    }
}
