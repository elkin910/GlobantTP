using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GlobantTP.RestService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.AddODataQueryFilter();


            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
            .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                                                                     "text/html",
                                                                     StringComparison.InvariantCultureIgnoreCase,
                                                                     true,
                                                                    "application/json"));

            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;

            
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
