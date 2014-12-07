using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Model.Interfaces;
using Newtonsoft.Json;

namespace Model.Implementation
{
    [DataContract(Name = "wind")]
    public class Wind
    {
        public Wind()
        {
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        [JsonProperty(PropertyName = "dir")]
        public string Dirrection { get; set; }
        [JsonProperty(PropertyName = "speed")]
        public string Speed { get; set; }
        [JsonProperty(PropertyName = "wind_unit")]
        public string Unit { get; set; }
    }
}
