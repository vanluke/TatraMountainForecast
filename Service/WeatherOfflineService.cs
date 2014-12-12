using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Model.Implementation;
using Model.Interfaces;
using Newtonsoft.Json;
using Weather = Model.Implementation.Weather;

namespace Service
{

    public class WeatherOfflineService : IWeatherService
    {
        public Task DeleteAsync(string city)
        {
            throw new NotImplementedException();
        }

        public Task<IWeatherContainer> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IWeatherContainer> GetAsync(string cityBox)
        {
            return await _context.Weathers.FirstOrDefaultAsync(v => v.Id.Equals(1));
        }

        public Task UpdateAsync(Weather wether)
        {
            throw new NotImplementedException();
        }

        public WeatherOfflineService()
        {
            _context = new ApplicationContext();
        }

        private readonly ApplicationContext _context;
    }
}
