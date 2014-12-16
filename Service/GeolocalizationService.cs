using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Model.Interfaces;
using Service.Implementation;

namespace Service
{
    public class GeolocalizationService : IGeolocalizationService
    {
        public GeolocalizationService()
        {
            _webClient = new WebClient();
        }
        public Task<IUserLocation> GetCurrentLocalization(string hostname)
        {
            return Task.FromResult(new UserLocation("50.0566531,19.9229965", "Cracow") as IUserLocation);
        }


        private string GetData(Uri url)
        {
            WebClient wc = new WebClient();
            Stream data = wc.OpenRead(url);
            String str;
            using (StreamReader sr = new StreamReader(data))
            {
                str = sr.ReadToEnd();
                data.Close();
            }
            return str;
        }
        private readonly WebClient _webClient;
    }
}
