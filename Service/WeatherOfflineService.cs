//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using Model.Implementation;
//using Model.Interfaces;
//using Newtonsoft.Json;
//using Weather = Model.Implementation.Weather;

//namespace Service
//{

//    public class WeatherOfflineService : IWeatherService
//    {
//        public Task<IEnumerable<Weather>> GetAsync()
//        {
//            var data = _context.Weathers.ToList();
//            return Task<IEnumerable<Weather>>.FromResult(data as IEnumerable<Weather>);
//        }

//        public async Task<Weather> GetAsync(string city)
//        {
//            return await _context.Weathers.FirstOrDefaultAsync(value => value.City.ToLower().Equals(city.ToLower()));
//        }

//        public async Task UpdateAsync(Weather wether)
//        {
//            var data = await _context.Weathers.FirstOrDefaultAsync(value => value.City.ToLower().Equals(wether.City.ToLower()));
//            if (data != null)
//            {
//                data = wether;
//                await _context.SaveChangesAsync();
//            }

//        }

//        public async Task DeleteAsync(string city)
//        {
//            var data = await _context.Weathers.FirstOrDefaultAsync(value => value.City.ToLower().Equals(city.ToLower()));
//            if (data != null)
//            {
//                _context.Weathers.Remove(data);
//                await _context.SaveChangesAsync();
//            }
//        }


//        public async Task<IUserLocation> GetCurrentLocalization(string hostname)
//        {
//            var apiLocation = _webClient.DownloadString("http://api.hostip.info/country.php");
//            var apiLocationInfo = _webClient.DownloadString("http://api.hostip.info/get_json.php");
//            var lonAndOthers = await _webClient.DownloadStringTaskAsync(new Uri(String.Format("http://freegeoip.net/json/{0}", hostname)));
//            return new UserLocation(apiLocation, apiLocationInfo) as IUserLocation;
//        }

//        public WeatherOfflineService(ApplicationContext context)
//        {
//           _webClient = new WebClient();
//            _context = context;
//        }

//        private readonly ApplicationContext _context;
//        private readonly WebClient _webClient;
//    }
//}
