using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Model.Implementation;
using Model.Interfaces;

namespace Service
{
    public class WeatherService : IWeatherService
    {
        public Task<IEnumerable<IWether>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IWether>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IWether wether)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<IUserLocation> GetCurrentLocalization(string hostname)
        {
            var apiLocation = _webClient.DownloadString("http://api.hostip.info/country.php");
            var apiLocationInfo = _webClient.DownloadString("http://api.hostip.info/get_json.php");
            var lonAndOthers = await _webClient.DownloadStringTaskAsync(new Uri(String.Format("http://freegeoip.net/json/{0}", hostname)));
            return new UserLocation(apiLocation, apiLocationInfo) as IUserLocation;
        }

        public WeatherService()
        {
           _webClient = new WebClient();
        }

        private readonly WebClient _webClient;
    }
}
