using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Extensions;

namespace GlobantTP.RestService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.AddODataQueryFilter();
            // Web API routes
            config.MapHttpAttributeRoutes();

            //Enable CORS - we have to install Microsoft.AspNet.WebApi.Cors from Package Manager Console before
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
