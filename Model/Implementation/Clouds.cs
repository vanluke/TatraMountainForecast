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
    [DataContract(Name = "clouds")]
    public class Clouds : IClouds
    {
        [JsonProperty(PropertyName = "all")]
        public int All { get; set; }
    }
}
