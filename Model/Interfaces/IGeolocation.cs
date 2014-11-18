using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IGeolocation
    {
        string Latitude { get; }
        string Longitude { get; }
    }
}
