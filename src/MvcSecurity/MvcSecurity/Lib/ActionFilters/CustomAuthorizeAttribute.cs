using System.Web;
using System.Web.Mvc;

namespace MvcSecurity.Lib.ActionFilters
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public CustomAuthorizeAttribute(SiteRoles roles)
        {            
            Roles = roles;
        }

        public new SiteRoles Roles;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var scope = new HttpScope(httpContext.Session);
            if (scope.IsAuthenticated == false) return false;
            return IsUserInRole(scope.Roles);
        }

        public bool IsUserInRole(SiteRoles roles)
        {
            return Roles == 0 || (Roles & roles) == roles;
        }
    }
}
