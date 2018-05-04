using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTT.Hack.Web.FrontEnd.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Index(int id)
        {
            return View(id);
        }
    }
}