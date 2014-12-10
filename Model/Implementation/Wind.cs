using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
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
