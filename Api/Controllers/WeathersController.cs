using System;
using System.Net;
using System.Net.Http;
using System.Security.Permissions;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Api.Controllers
{
    public class WeathersController : BaseApiController
    {
        // GET api/values//Geolocation geolocation
        public async Task<HttpResponseMessage> Get() // two days weathres http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&query=52.2,21&temp_unit=c&ws_unit=kph  private readonly string _url = "http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&output=json&query=SW1";
        {
            var boxLocation = await _geolocalizationService.GetCurrentLocalization(Environment.UserDomainName);

            var result = await _weatherService.GetAsync(boxLocation.CurrentLocation);

            if (String.IsNullOrEmpty(result.Cod))
            {
                result.Cod = "200";
            }

            if (result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to fetch weather data");
        }

        public WeathersController(IWeatherService weatherService, IGeolocalizationService geolocalizationService) : base()
        {
            _weatherService = weatherService;
            _geolocalizationService = geolocalizationService;
        }

        private readonly IWeatherService _weatherService;

        private readonly IGeolocalizationService _geolocalizationService;
    }
}
