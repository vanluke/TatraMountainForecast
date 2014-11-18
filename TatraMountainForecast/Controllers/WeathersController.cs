using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using TatraMountainForecast.Models;

namespace TatraMountainForecast.Controllers
{
    public class WeathersController : ApiController
    {
        public async Task<IEnumerable<Weather>> Get()
        {
            return WeatherRepository.CreateWeatherList();
        }
    }
}
