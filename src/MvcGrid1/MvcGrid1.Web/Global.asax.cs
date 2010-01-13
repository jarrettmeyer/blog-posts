using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcGrid1.Core.Lib.Startup;

namespace MvcGrid1.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteRegistrar.RegisterRoutes(RouteTable.Routes);            
        }        
    }
}