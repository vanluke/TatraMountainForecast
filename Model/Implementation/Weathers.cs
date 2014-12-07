using Model.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model.Implementation
{
    public class Weathers
    {
        public Weathers()
        {
            Weather = new Weather();
        }

        [JsonProperty(PropertyName = "weather")]
        public Weather Weather { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
