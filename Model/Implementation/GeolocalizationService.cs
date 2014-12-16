using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Model.Implementation
{
    public class GeolocalizationService : IGeolocalizationService
    {
        public Task<IUserLocation> GetCurrentLocalization(string hostname)
        {
            throw new NotImplementedException();
        }
    }
}
