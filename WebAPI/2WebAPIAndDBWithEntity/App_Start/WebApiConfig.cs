using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApiContrib.Formatting.Jsonp;

namespace _2WebAPIAndDBWithEntity
{
    //if the request is made from browser, we cant edit the Accept header in the request.
    //to circumvent that, we will create a new custom mediatype formatter and use it when we receive the 
    //text/html Accept header , i.e. default accept header from browser.
    //in the below example if text/html accept header is received, we respond with application/json
    //this will not affect the behaviour if application/json or application/xml is received, they will work as expected.
  public class MyCustomMediaTypeFormatter : JsonMediaTypeFormatter{
        public MyCustomMediaTypeFormatter()
        {
            this.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
public static class WebApiConfig
    {
        
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


            //the below code will indent the json data in raw tab of fiddler
            //config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            //turn the property name into camel case
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

            //register our cumstom formatter
            //config.Formatters.Add(new MyCustomMediaTypeFormatter());

            //the below code will handle jsonp formatting for enabling cross domain/origin api call using ajax
            JsonpMediaTypeFormatter jsonpMediaTypeFormatter= new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
            config.Formatters.Insert(0, jsonpMediaTypeFormatter);
        }
    }
}
