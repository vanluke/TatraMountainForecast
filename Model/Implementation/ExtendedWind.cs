using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
{
    [DataContract(Name = "wind2")]
    public class ExtendedWind :  Wind
    {
        [JsonProperty(PropertyName = "dir_degree")]
        public string Degree { get; set; }
    }
}
