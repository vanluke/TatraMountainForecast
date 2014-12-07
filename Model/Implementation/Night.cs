using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
{
    [DataContract(Name = "night")]
    public class Night
    {
        public Night()
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
