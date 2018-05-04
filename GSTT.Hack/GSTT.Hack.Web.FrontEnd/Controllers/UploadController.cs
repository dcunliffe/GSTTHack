using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTT.Hack.Web.FrontEnd.Controllers
{
    [Authorize]
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( HttpPostedFileBase file)
        {
            //var path = "F:\\TempUpload\\";

            //if (file != null && file.ContentLength>0)
            //{
            //    if(!Directory.Exists(path)) Directory.CreateDirectory(path);
            //}

            //file.SaveAs(path + Path.GetFileName(file.FileName));    

            return View();
        }
    }
}