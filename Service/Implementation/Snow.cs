using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Service.Implementation
{
    [DataContract(Name = "snow")]
    public class Snow : ISnow
    {
        [JsonProperty(PropertyName = "1h")]
        public double Duration { get; set; }
    }
}
