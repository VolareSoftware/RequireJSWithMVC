using System.Web;
using System.Web.Mvc;

namespace RequireJSWithMVC.Extensions
{
    public static class PathHelpers
    {
        public static string ScriptsPath(this HtmlHelper helper, string pathWithoutScripts)
        {
#if (DEBUG)
            var scriptsPath = "~/Scripts/";
#else
            var scriptsPath = "~/Scripts-Build/";
#endif

            return VirtualPathUtility.ToAbsolute(scriptsPath + pathWithoutScripts);
        }

        public static string StylesPath(this HtmlHelper helper, string pathWithoutStyles)
        {
#if (DEBUG)
            var stylesPath = "~/Styles/";
#else
            var stylesPath = "~/Styles-Build/";
#endif
            return VirtualPathUtility.ToAbsolute(stylesPath + pathWithoutStyles);
        }
    }
}