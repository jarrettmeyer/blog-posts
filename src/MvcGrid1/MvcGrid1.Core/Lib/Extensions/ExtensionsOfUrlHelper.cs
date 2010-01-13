using System.Web.Mvc;

namespace MvcGrid1.Core.Lib.Extensions
{
    public static class ExtensionsOfUrlHelper
    {
        public static string IncludeCss(this UrlHelper url, string css)
        {
            var path = string.Format("~/Content/Stylesheets/{0}", css);
            return string.Format("<link type=\"text/css\" rel=\"Stylesheet\" href=\"{0}\"/>", url.Content(path));
        }

        public static string IncludeJs(this UrlHelper url, string js)
        {
            var path = string.Format("~/Content/Scripts/{0}", js);
            return url.Content(path);
        }
    }
}
