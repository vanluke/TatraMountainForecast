using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Model.Implementation;
using Model.Interfaces;
using Newtonsoft.Json;
using Service;

namespace Api.Controllers
{
    public class WeathersController : BaseApiController
    {
        // GET api/values//Geolocation geolocation
        public async Task<HttpResponseMessage> Get() // two days weathres http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&query=52.2,21&temp_unit=c&ws_unit=kph
        {
            var geolocation = new Geolocation("50.0566531", "19.9229965");
           // await DoJob();
            Uri uri = new Uri(_url);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.openweathermap.org/");
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response =
                    await client.GetAsync(String.Format("data/2.5/box/city?bbox={0}&units=metric&cluster=yes&APPID={1}", PolandBBox, Apikey));
                if (response.IsSuccessStatusCode)
                {
                    try 
                    {
                        response.Content.Headers.
                        var retval = await response.Content.ReadAsAsync<WeatherContainer>();

                        return Request.CreateResponse(HttpStatusCode.OK, retval);
                    }
                    catch (Exception)
                    {     
                        throw;
                    }
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to fetch weather data");
        }
        private const string Apikey= "a27c7d325a06178a1b9b0bdb318517b4";

        private const string PolandBBox ="14.12,48.91,24.25,54.88,10";
        //public async Task<HttpResponseMessage> Get(Geolocation geolocation)
        //{
        //    Uri uri = new Uri(_url);
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://www.myweather2.com/developer/");
        //        client.DefaultRequestHeaders.Accept.Clear();

        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage response = await client.GetAsync(String.Format("forecast.ashx?uac=0HDgjFKVeJ&output=json&query={0},{1}&temp_unit=c&ws_unit=kph", geolocation.Latitude, geolocation.Longitude));
        //        if (response.IsSuccessStatusCode)
        //        {
        //            try
        //            {
        //                var retval = await response.Content.ReadAsAsync<Weathers>();
        //                return Request.CreateResponse(HttpStatusCode.OK, retval);
        //            }
        //            catch (Exception)
        //            {
        //                throw;
        //            }
        //        }
        //    }
        //    return Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to fetch weather data");
        //}

        //private async Task DoJob()
        //{
        //    ApplicationContext context = new ApplicationContext();

        //    Uri uri = new Uri(_url);
        //    var clientData = context.CityPossitions.ToList();
        //    var wlist = new List<Model.Implementation.Weather>();
        //    using (var client = new HttpClient())
        //    {
        //        try
        //        {
        //            client.BaseAddress = new Uri("http://www.myweather2.com/developer/");
        //            client.DefaultRequestHeaders.Accept.Clear();
             
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
        //            foreach (var one in clientData)
        //            {
        //                var str = String.Format(
        //                    "forecast.ashx?uac=0HDgjFKVeJ&output=json&query={0},{1}&temp_unit=c&ws_unit=kph",
        //                    one.Latitude, one.Longitude);
        //                HttpResponseMessage response = await client.GetAsync(str);
        //                if (response.IsSuccessStatusCode)
        //                {
        //                    var retval = await response.Content.ReadAsAsync<Weathers>();
        //                    var weather = new Weather(one.Location, retval.Weather.CurrentWeather as List<CurrentWeather>,
        //                        retval.Weather.Forecasts as List<Forecast>);
        //                    wlist.Add(weather);
        //                }

        //            }
        //        }
        //        catch (Exception)
        //        {   
        //            throw;
        //        }
               

        //        var ser  = JsonConvert.SerializeObject(wlist);
        //    }
        //}

        //[Route("api/Weathers/{day}")]
        //public HttpResponseMessage Get(string day)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

        public WeathersController(/*IWeatherService weatherService*/)
        {
           // _weatherService = new WeatherOfflineService(new ApplicationContext());
        }

        private readonly IWeatherService _weatherService;

        public string CurrentLocalization { get; set; }

        private readonly string _url = "http://www.myweather2.com/developer/forecast.ashx?uac=0HDgjFKVeJ&output=json&query=SW1";
    }
}
