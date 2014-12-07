using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Implementation;
using Newtonsoft.Json;

namespace Model.Interfaces
{
    public interface IDay
    {
        [Key]
        int Id { get; }
        [JsonProperty(PropertyName = "weather_code")]
        string Code { get; }
        [JsonProperty(PropertyName = "weather_text")]
        string Comments { get; }
        [JsonProperty(PropertyName = "wind")]
        IEnumerable<IExtendedWind> Winds { get; }
    }
}
