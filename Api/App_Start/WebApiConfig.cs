using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using Api.App_Start;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace Api
{
    public static class WebApiConfig
    {
        public class TextPlainXmlMediaTypeFormatter : XmlMediaTypeFormatter
        {
            public TextPlainXmlMediaTypeFormatter()
            {
                SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
            }
        }
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            GlobalConfiguration.Configuration.Formatters.Insert(0, new TextMediaTypeFormatter());
            //config.Formatters.Add(new TextMediaTypeFormatter());
            //config.Formatters.Add(new TextPlainXmlMediaTypeFormatter());
        }
    }
}
