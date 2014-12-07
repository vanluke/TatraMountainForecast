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
    public interface IWeathers
    {
        [JsonProperty(PropertyName = "weather")]
        IWeather Weather { get; }
        [Key]
        int Id { get; }
    }
}
