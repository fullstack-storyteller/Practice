using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace _2WebAPIAndDBWithEntity
{
    public class RequireHttps: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //actionContext is the object which will contain both request and response object
            if (actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
            {
                //make a response which says that the particular uri, that is being request is available 
                //but the request needs to be https not http
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Found);
                actionContext.Response.Content = new StringContent("<p>Use HTTPS instead of HTTPS</p>", System.Text.Encoding.UTF8);

                //now redirect the request to https
                UriBuilder uriBuilder = new UriBuilder(actionContext.Request.RequestUri);
                uriBuilder.Scheme = Uri.UriSchemeHttps;
                uriBuilder.Port = 44349; //the port number of our ssl web api. Check the first screenshot

                //finally set the location header to the new uri that we created for https
                actionContext.Response.Headers.Location = uriBuilder.Uri;
            }
            else
            {
                base.OnAuthorization(actionContext);
            }
        }
    }
}