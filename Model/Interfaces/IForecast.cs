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
    public interface IForecast
    {
        [Key]
        int Id { get; set; }
        [JsonProperty(PropertyName = "date")]
        string Date { get; set; }
        [JsonProperty(PropertyName = "day")]
        IEnumerable<IDay> Days { get; set; }
        [JsonProperty(PropertyName = "day_max_temp")]
        string DayMaxTemperature { get; set; }
        [JsonProperty(PropertyName = "night")]
        IEnumerable<INight> Nights { get; set; }
        [JsonProperty(PropertyName = "night_min_temp")]
        string NightMinTemperature { get; set; }
        [JsonProperty(PropertyName = "temp_unit")]
        string Unit { get; set; }
    }
}
