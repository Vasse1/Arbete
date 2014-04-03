using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class RegisterObjectController : Controller
    {
        //
        // GET: /Object/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Object/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Object/Create
        [Authorize(Roles = "Renter")]
        public ActionResult Create()
        {
            return View(new CreateModels {RentableObject= new RentableObject { SeasonStart=DateTime.Today,SeasonEnd=DateTime.Today}});
        }

        //
        // POST: /Object/Create

        [HttpPost]
        [Authorize(Roles = "Renter")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateModels createModels, IEnumerable<HttpPostedFileBase> file)
        {

            // TODO: Add insert logic here
            using (var db = new UsersContext())
            {
                if (createModels.RentableObject.NumberOfRooms == 0)
                    ModelState.AddModelError("RentableObject.NumberOfRooms", "Skriv minst en siffra");
                if (createModels.RentableObject.Beds == 0)
                    ModelState.AddModelError("RentableObject.Beds", "Skriv minst en siffra");
                if (createModels.RentableObject.Floors == 0)
                    ModelState.AddModelError("RentableObject.Floors", "Skriv minst en siffra");
                if (createModels.RentableObject.Price == 0)
                    ModelState.AddModelError("RentableObject.Price", "Skriv minst en siffra");
                if (createModels.RentableObject.SizeSqm == 0)
                    ModelState.AddModelError("RentableObject.SizeSqm", "Skriv minst en siffra");
                if (createModels.RentableObject.ZipCode == 0)
                    ModelState.AddModelError("RentableObject.ZipCode", "ex. 12345");
                if (ModelState.IsValid)
                {
                    db.RentableObjects.Add(createModels.RentableObject);
                    db.SaveChanges();
                        foreach (var item in file)
                        {
                            if (item != null)
                            {
                                item.SaveAs(HttpContext.Server.MapPath("~/Content/Picture/" + item.FileName));
                                createModels.Picture.Path = "~/Content/Picture/" + item.FileName;
                                createModels.Picture.RentableObject = createModels.RentableObject;
                                db.Pictures.Add(createModels.Picture);
                                db.SaveChanges();
                            }
                        }                  
                    
                        
                       
                    
                    return RedirectToAction("Index", "Home");
                }
                return View("Create");
            }
        }

        //
        // GET: /Object/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Object/Edit/5

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

        //
        // GET: /Object/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Object/Delete/5

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
