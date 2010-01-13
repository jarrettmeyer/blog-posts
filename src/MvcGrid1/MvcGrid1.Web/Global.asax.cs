using System.Web.Routing;
using MvcGrid1.Core.Controllers;
using MvcGrid1.Core.Lib;
using MvcGrid1.Core.Lib.Startup;
using Ninject;
using Ninject.Web.Mvc;

namespace MvcGrid1.Web
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            return AppScope.BuildKernel();
        }

        protected override void OnApplicationStarted()
        {
            RouteRegistrar.RegisterRoutes(RouteTable.Routes);
            var assembly = typeof(ApplicationController).Assembly;
            RegisterAllControllersIn(assembly);
        }
    }
}