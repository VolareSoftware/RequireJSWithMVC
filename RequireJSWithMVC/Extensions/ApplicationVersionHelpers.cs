using System.Globalization;
using System.Reflection;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace RequireJSWithMVC.Extensions
{
    public static class ApplicationVersionHelpers
    {
        private const string _assemblyRevisionNumberKey = "AssemblyRevisionNumber";

        public static string AssemblyRevisionNumber(this HtmlHelper helper)
        {
#if (DEBUG) 
            return string.Empty;
#else
            if (HttpRuntime.Cache[_assemblyRevisionNumberKey] == null)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyRevisionNumber = assembly.GetName().Version.Revision.ToString(CultureInfo.InvariantCulture);

                HttpRuntime.Cache.Insert(_assemblyRevisionNumberKey, assemblyRevisionNumber,
                    new CacheDependency(assembly.Location));
            }

            return HttpRuntime.Cache[_assemblyRevisionNumberKey] as string;
#endif
        }
    }
}