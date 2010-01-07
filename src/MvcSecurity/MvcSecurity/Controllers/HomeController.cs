using System.Web.Mvc;
using MvcSecurity.Lib;
using MvcSecurity.Lib.ActionFilters;

namespace MvcSecurity.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [CustomAuthorize(SiteRoles.Manager|SiteRoles.ProjectLead)]
        public ActionResult Protected()
        {
            return View();
        }
    }
}
