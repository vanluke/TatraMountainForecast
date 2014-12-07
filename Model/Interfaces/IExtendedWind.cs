using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model.Interfaces
{
    public interface IExtendedWind : IWind
    {
        [JsonProperty(PropertyName = "dir_degree")]
        string Degree { get; }
    }
}
