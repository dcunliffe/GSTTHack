using GSTT.Hack.Management.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GSTT.Hack.Management.FrontEnd.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        // GET: Subscriptions
        public ActionResult Index()
        {
            var categoryList = new List<CategoryModel>();
            categoryList.Add(new CategoryModel() { Name = "Cat1", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat2", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat3", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat4", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat5", IsSelected = false });

            var dummyModel =
                new List<SubscriptionsModel>();
            dummyModel.Add(
                new SubscriptionsModel()
                {
                    Categories = categoryList,
                    EmailAddress = "Test1234@test.com"
                });
            return View(dummyModel);
        }

        [Authorize(Roles = "addSubscription")]
        // GET: Subscriptions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subscriptions/Create
        public ActionResult Create()
        {
            var categoryList = new List<CategoryModel>();
            categoryList.Add(new CategoryModel() { Name = "Cat1", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat2", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat3", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat4", IsSelected = false });
            categoryList.Add(new CategoryModel() { Name = "Cat5", IsSelected = false });

            var dummyModel = new  SubscriptionsModel()
                {
                Categories = categoryList
                };
            return View(dummyModel);
        }

        // POST: Subscriptions/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
