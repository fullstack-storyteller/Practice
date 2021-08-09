using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace _2WebAPIAndDBWithEntity
{
    public class BasicAuthentication: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //base.OnAuthorization(actionContext);
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request
                    .CreateResponse(System.Net.HttpStatusCode.Unauthorized, "<p>No Authorization Header</p>", "text/html"); //no authorization header in request
                return; 
            }
            string authorizationToken = actionContext.Request.Headers.Authorization.Parameter;
            //the above is base64 encoded
            string decodedAuthorizationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authorizationToken));
            //the above is decoded utf8 encoded string
            string[] usernamePassword = decodedAuthorizationToken.Split(':');//username:password
            string username = usernamePassword[0];
            string password = usernamePassword[1];
            if(!EmployeeSecurity.Login(username, password))
            {
                actionContext.Response = actionContext.Request
                    .CreateResponse(System.Net.HttpStatusCode.Unauthorized,"<p>Login Failed</p>", "text/html"); //authentication failed
                return;
            }
            //doing the below line just for the heck of it.
            //creating a new generic identity and setting it to currentPrincipal of the current thread
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
        }
    }
}