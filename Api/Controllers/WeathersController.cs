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
        public async Task<HttpResponseMessage> Get() // two days weathres http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&query=52.2,21&temp_unit=c&ws_unit=kph
        {
            Uri uri = new Uri(_url);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.myweather2.com/developer/");
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(String.Format("forecast.ashx?uac=0HDgjFKVeJ&output=json&query={0}&temp_unit=c&ws_unit=kph", CurrentLocalization));
                if (response.IsSuccessStatusCode)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, await response.Content.ReadAsAsync<Weathers>());
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to fetch weather data");
        }

        [Route("api/Weathers/{day}")]
        public async Task<HttpResponseMessage> Get(string day)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public WeathersController(/*IWeatherService weatherService*/)
        {
            _weatherService = new WeatherService();
            CurrentLocalization = _weatherService.GetCurrentLocalization(GetUserIP()).Result.CurrentLocation;
        }

        private string GetUserIP()
        {
            //string ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            //if (string.IsNullOrEmpty(ip))
            //{
            //    ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            //}
            //[0].MapToIPv4()
            return "127.0.0.1";
        }

        private readonly IWeatherService _weatherService; 

        public string CurrentLocalization { get; set; }

        private readonly string _url = "http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&output=json&query=SW1";
    }
}
