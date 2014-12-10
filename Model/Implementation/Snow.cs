﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
{
    [DataContract(Name = "snow")]
    public class Snow : ISnow
    {
        [JsonProperty(PropertyName = "1h")]
        public double Duration { get; set; }
    }
}
