using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Service.Implementation
{
    [DataContract(Name = "rain")]
    public class Rain : IRain
    {
        [JsonProperty(PropertyName = "1h")]
        public double Duration { get; set; }
    }
}
