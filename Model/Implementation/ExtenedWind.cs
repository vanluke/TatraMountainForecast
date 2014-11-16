using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Model.Implementation
{
    [DataContract(Name = "wind2")]
    public class ExtenedWind : Wind
    {
        [JsonProperty(PropertyName = "dir_degree")]
        public string Degree { get; set; }
    }
}
