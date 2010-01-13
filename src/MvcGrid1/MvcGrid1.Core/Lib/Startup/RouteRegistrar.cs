using System.Web.Mvc;
using System.Web.Routing;

namespace MvcGrid1.Core.Lib.Startup
{
    public class RouteRegistrar
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("NameRoute", "Names/{id}", new { controller = "Names", action = "Details" }, new { id = @"\d+" });
            routes.MapRoute("DefaultRoute", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = string.Empty });
        }
    }
}
