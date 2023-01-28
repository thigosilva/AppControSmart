using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FSL.XFApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{https://10.39.46.31}",
                defaults: new { id = RouteParameter.Optional }
            );

            
        }
    }
}


//http://192.168.1.246:32768/swagger/index.html
//http://10.39.46.31:32768/swagger/index.html