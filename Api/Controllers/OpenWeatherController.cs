using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class OpenWeatherController : BaseApiController
    {
        // GET: api/OpenWeather
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OpenWeather/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OpenWeather
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/OpenWeather/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OpenWeather/5
        public void Delete(int id)
        {
        }
    }
}
