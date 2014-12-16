using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Service.Implementation
{
    [DataContract(Name = "clouds")]
    public class Clouds : IClouds
    {
        [JsonProperty(PropertyName = "all")]
        public int All { get; set; }
    }
}
