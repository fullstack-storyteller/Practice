using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_3_WebApiTokenAuthenticationUsingOwin.Startup))]

namespace _3_WebApiTokenAuthenticationUsingOwin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
