using System;
using GSTT.Hack.Models.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Gstt.Hack.Api.DocumentMetaData.Controllers
{
    public class ManagementController : ApiController
    {
        // GET api/values
        public IEnumerable<RegistrationDto> Get()
        {
            return new List<DocumentMetaDataDto>();
        }

        // GET: Subscriptions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subscriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST api/values
        public void Post([FromBody]RegisterDto RegisterSubscription)
        {

        }

      

        // GET: Subscriptions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Subscriptions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Subscriptions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Subscriptions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
