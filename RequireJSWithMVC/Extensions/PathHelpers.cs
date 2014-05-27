using System.Web;
using System.Web.Mvc;

namespace RequireJSWithMVC.Extensions
{
    public static class PathHelpers
    {
        public static string ScriptsPath(this HtmlHelper helper, string pathWithoutScripts)
        {
            var fullPath = "";
#if (DEBUG)
            var scriptsPath = "~/Scripts/";
            fullPath = VirtualPathUtility.ToAbsolute(scriptsPath + pathWithoutScripts);
#else
            var scriptsPath = "~/Scripts-Build/";
            fullPath = VirtualPathUtility.ToAbsolute(scriptsPath + pathWithoutScripts + "?v=" + helper.AssemblyRevisionNumber());
#endif
            return fullPath;
        }

        public static string StylesPath(this HtmlHelper helper, string pathWithoutStyles)
        {
            var fullPath = "";
#if (DEBUG)
            var stylesPath = "~/Styles/";
            fullPath = VirtualPathUtility.ToAbsolute(stylesPath + pathWithoutStyles);
#else
            var stylesPath = "~/Styles-Build/";
            fullPath = VirtualPathUtility.ToAbsolute(stylesPath + pathWithoutStyles + "?v=" + helper.AssemblyRevisionNumber());
#endif
            return fullPath;
        }
    }
}