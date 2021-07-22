using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _1WebAPIIntro
{
    public static class WebApiConfig
    {
        /*
         This register method is where we are defining the route template of the api
        domain-name/api/values/id
        values->can change depending on the controller name
        id-> can change depending on the requirement
         */
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
