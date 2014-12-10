using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Interfaces;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Model.Implementation
{
    [DataContract(Name = "weather")]
    public class Weather : IWeather
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "main")]
        public string QuickDescription { get; set; }

        [JsonProperty(PropertyName = "description ")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }
    }
}
