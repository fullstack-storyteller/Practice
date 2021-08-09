using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiContrib.Formatting.Jsonp;

namespace _2WebAPIAndDBWithEntity
{
    //if the request is made from browser, we cant edit the Accept header in the request.
    //to circumvent that, we will create a new custom mediatype formatter and use it when we receive the 
    //text/html Accept header , i.e. default accept header from browser.
    //in the below example if text/html accept header is received, we respond with application/json
    //this will not affect the behaviour of application/json or application/xml is received, they will work as expected.
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

            //register our custom formatter
            config.Formatters.Add(new MyCustomMediaTypeFormatter());


            //the below code will handle jsonp formatting for enabling cross domain/origin api call using ajax
            //JsonpMediaTypeFormatter jsonpMediaTypeFormatter= new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
            //config.Formatters.Insert(0, jsonpMediaTypeFormatter);

            
            //The below code will handle CORS for enabling Cross Domain Resource sharing
            //i.e. for enabling cross domain api calls using ajax
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            //remember the above method takes all three parameters as comma separated values.
            // parameter 1: comma seperated list of api domain names, give port numbers too
            // parameter 2: comma separated list of header atteributes like Accept: application/json 
            // parameter 3: comma separated list of http methods GET, POST

            //Finally register the enable cors attribute with config object
            config.EnableCors(cors);


            //Register the authorization filter for http to https migration
            //Remember that registering the filter in WebApiConfig.cs file has global effect, that means all
            //the controllers and all the action methods will have this new authorization filter enabled
            //for them.
            config.Filters.Add(new RequireHttps());

            //register the basic authentication filter globally.
            config.Filters.Add(new BasicAuthentication());
        }
    }
}
