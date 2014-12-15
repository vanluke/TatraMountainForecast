using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.ClientServices;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Api.Controllers;
using Autofac;
using Autofac.Integration.WebApi;
using Model.Interfaces;
using Service;

namespace Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var config = GlobalConfiguration.Configuration;

            var builder = new ContainerBuilder();

            builder.RegisterType<ApplicationContext>().AsSelf();

            // Register individual components
            if (!ConnectivityStatus.IsOffline)
            {
                builder.RegisterType<WeatherOfflineService>().As<IWeatherService>();
            }
            else
            { 
                builder.RegisterType<OpenWeatherService>().As<IWeatherService>();
            }

            builder.RegisterType<GeolocalizationService>().As<IGeolocalizationService>();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterWebApiFilterProvider(config);

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            builder.RegisterType<WeathersController>().InstancePerRequest();
        }

    }
}
