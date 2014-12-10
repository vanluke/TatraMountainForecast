
using Newtonsoft.Json;

namespace Model.Interfaces
{
    public interface IPossition
    {
        string Location { get; }
        [JsonProperty(PropertyName = "lon")]
        double Latitude { get; }
        [JsonProperty(PropertyName = "lat")]
        double Longitude { get; }
    }
}
