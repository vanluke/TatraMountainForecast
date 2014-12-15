using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Model.Interfaces;
using Service.Implementation;

namespace Service
{
    public class OpenWeatherService : IWeatherService
    {
        public Task UpdateAsync(IWeather wether)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string city)
        {
            throw new NotImplementedException();
        }

        public async Task<IWeatherContainer> GetAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.openweathermap.org/");
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(String.Format("data/2.5/box/city?bbox={0}&units=metric&cluster=yes&APPID={1}", PolandBBox, Apikey));
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var result = await response.Content.ReadAsAsync<WeatherContainer>();
                        return result;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                return null;
            }
        }

        public async Task<IWeatherContainer> GetAsync(string city)
        {
            return await GetAsync();
        }

        private const string Apikey = "a27c7d325a06178a1b9b0bdb318517b4";

        private const string PolandBBox = "14.12,48.91,24.25,54.88,10";
    }
}
