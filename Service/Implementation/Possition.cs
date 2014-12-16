using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Service.Implementation
{
    [DataContract(Name = "coord")]
    public class Possition : IPossition
    {
        public string Location { get; set; }
        [JsonProperty(PropertyName = "lat")]
        public double Latitude { get; set; }
        [JsonProperty(PropertyName = "lon")]
        public double Longitude { get; set; }
    }
}
