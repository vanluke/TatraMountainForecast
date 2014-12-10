using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Model.Interfaces
{
    public interface IWind
    {
        double Speed { get; }
        double Deg { get; }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //int Id { get; }
        //[JsonProperty(PropertyName = "dir")]
        //string Dirrection { get; }
        //[JsonProperty(PropertyName = "speed")]
        //string Speed { get; }
        //[JsonProperty(PropertyName = "wind_unit")]
        //string Unit { get; }
    }
}
