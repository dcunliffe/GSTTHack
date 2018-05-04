using GSTT.Hack.Models.Dto;
using GSTT.Hack.Web.FrontEnd.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GSTT.Hack.Web.FrontEnd.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            return View();
        }

    }
}

