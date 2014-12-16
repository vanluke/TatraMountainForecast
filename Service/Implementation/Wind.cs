using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Service.Implementation
{
    [DataContract(Name = "wind")]
    public class Wind : IWind
    {
        [JsonProperty(PropertyName = "speed")]
        public double Speed { get; set; }

        [JsonProperty(PropertyName = "deg")]
        public double Deg { get; set; }
    }
}
