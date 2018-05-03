using System.Web;
using System.Web.Mvc;

namespace Gstt.Hack.Api.DocumentMetaData
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
