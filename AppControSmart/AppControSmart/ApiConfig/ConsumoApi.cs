using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace AppControSmart.ApiConfig
{
    public static void ApiControl(HttpConfiguration config)
    {
        
        config.MapHttpAttributeRoutes();

        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{https://10.39.46.31:32768/swagger/index.html}",
            defaults: new { id = RouteParameter.Optional }
        );

       
    }
}

