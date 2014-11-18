using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using App_Start;
using Model.Implementation;
using System.Threading.Tasks;

namespace TatraMountainForecast
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UserGeolocation = GetUserLocation().Result;
        }

        private async Task<Geolocation> GetUserLocation()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Geolocation geolocation = null;
            var response = await client.GetAsync("http://ipinfo.io");
            if (response.IsSuccessStatusCode)
            {
                var possition = await response.Content.ReadAsAsync<IPLocation>();
                var userpos = possition.Loc.Split(',');
                geolocation = new Geolocation(userpos[0], userpos[1]);
            }
            if (geolocation == null)
            {
                geolocation = new Geolocation("50.0566531", "19.9229965");
            }
            return geolocation;
        }

        public static Geolocation UserGeolocation { get; private set; }
    }
}
