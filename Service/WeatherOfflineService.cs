using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Service
{

    public class WeatherOfflineService : IWeatherService
    {
        public Task DeleteAsync(string city)
        {
            throw new NotImplementedException();
        }

        public async Task<IWeatherContainer> GetAsync()
        {
            return await _context.Weathers.FirstOrDefaultAsync(v => v.Id.Equals(1));
        }

        public async Task<IWeatherContainer> GetAsync(string cityBox)
        {
            return await _context.Weathers.FirstOrDefaultAsync(v => v.Id.Equals(1));
        }

        public Task UpdateAsync(IWeather wether)
        {
            throw new NotImplementedException();
        }

        public WeatherOfflineService(ApplicationContext context)
        {
            _context = context;
        }

        private readonly ApplicationContext _context;
    }
}
