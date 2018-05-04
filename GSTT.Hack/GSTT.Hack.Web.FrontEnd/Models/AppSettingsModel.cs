using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTT.Hack.Web.FrontEnd.Models
{
    public static class AppSettingsModel
    {
        public static string UrlMetaData => System.Configuration.ConfigurationManager.AppSettings["Url.Metadata"];
    }
}