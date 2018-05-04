using GSTT.Hack.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTT.Hack.Web.FrontEnd.Controllers
{
    [Authorize]
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            var list = new List<DocumentMetaDataDto>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(new DocumentMetaDataDto
                {
                    Id = 10000,
                    Category = "category 1",
                    IsSecure = true,
                    Comment = " some comment some comment"
                });
            }


            return View(list);
        }
    }
}