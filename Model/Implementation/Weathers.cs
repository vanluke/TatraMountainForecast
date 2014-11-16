using Newtonsoft.Json;

namespace Model.Implementation
{
    public class Weathers
    {
        [JsonProperty(PropertyName = "weather")]
        public Weather Weather { get; set; }
    }
}
