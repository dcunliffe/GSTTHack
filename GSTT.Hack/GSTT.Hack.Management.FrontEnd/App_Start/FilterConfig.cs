﻿using System.Web;
using System.Web.Mvc;

namespace GSTT.Hack.Management.FrontEnd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
