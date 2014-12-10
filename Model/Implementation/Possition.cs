using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
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
