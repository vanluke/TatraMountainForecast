using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Model.Implementation;

namespace Api.Controllers
{
    public class WeathersController : BaseApiController
    {
        // GET api/values
        public async Task<HttpResponseMessage> Get()
        {
            Uri uri = new Uri(_url);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.myweather2.com/developer/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("forecast.ashx?uac=0HDgjFKVeJ&output=json&query=SW1");
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

        private readonly string _url = "http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&output=json&query=SW1";
    }
}
