using Newtonsoft.Json;

namespace Model.Implementation
{
    public class Wind
    {
        [JsonProperty(PropertyName = "dir")]
        public string Dirrection { get; set; }
        [JsonProperty(PropertyName = "speed")]
        public string Speed { get; set; }
        [JsonProperty(PropertyName = "wind_unit")]
        public string Unit { get; set; }
    }
}
