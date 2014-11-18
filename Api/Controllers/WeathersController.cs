using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Model.Implementation;
using Model.Interfaces;
using Service;

namespace Api.Controllers
{
    public class WeathersController : BaseApiController
    {  
        // GET api/values
        public async Task<HttpResponseMessage> Get(Geolocation geolocation) // two days weathres http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&query=52.2,21&temp_unit=c&ws_unit=kph
        {
            Uri uri = new Uri(_url);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.myweather2.com/developer/");
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(String.Format("forecast.ashx?uac=0HDgjFKVeJ&output=json&query={0},{1}&temp_unit=c&ws_unit=kph", geolocation.Latitude, geolocation.Longitude));
                if (response.IsSuccessStatusCode)
                {
                    var retval = await response.Content.ReadAsAsync<Weathers>();
                    return Request.CreateResponse(HttpStatusCode.OK, retval);
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to fetch weather data");
        }

        [Route("api/Weathers/{day}")]
        public HttpResponseMessage Get(string day)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public WeathersController(/*IWeatherService weatherService*/)
        {
            _weatherService = new WeatherService();
        }

        private readonly IWeatherService _weatherService; 

        public string CurrentLocalization { get; set; }

        private readonly string _url = "http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&output=json&query=SW1";
    }
}
