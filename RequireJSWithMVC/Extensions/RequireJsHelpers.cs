using System;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RequireJSWithMVC.Extensions
{
    public static class RequireJsHelpers
    {
        public static MvcHtmlString InitPageMainModule(this HtmlHelper helper, string pageModule)
        {
            var require = new StringBuilder();

#if (DEBUG)
            var scriptsPath = "~/Scripts/";
#else
            var scriptsPath = "~/Scripts-Build/";
#endif

            var absolutePath = VirtualPathUtility.ToAbsolute(scriptsPath);

            require.AppendLine("<script>");
#if (DEBUG)
            require.AppendFormat("    require([\"{0}main.js\"]," + Environment.NewLine, absolutePath);
#else
            require.AppendFormat("    require([\"{0}main.js?v={1}\"]," + Environment.NewLine, absolutePath, helper.AssemblyRevisionNumber());
#endif
            require.AppendLine("        function() {");
            require.AppendFormat("            require([\"{0}\", \"domReady!\"]);" + Environment.NewLine, pageModule);
            require.AppendLine("        }");
            require.AppendLine("    );");
            require.AppendLine("</script>");

            return new MvcHtmlString(require.ToString());
        }
    }
}