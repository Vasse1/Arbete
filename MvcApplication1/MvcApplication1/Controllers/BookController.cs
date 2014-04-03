using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        public ActionResult Index(int id)
        {
            using (var db = new UsersContext())
            {
                var rental = new Rental();
                List<DateTime> allDates = new List<DateTime>();
                rental.RentableObject = db.RentableObjects.Include("Picture").Where(r => r.Id == id).Single();
                foreach (var item in db.Rentals.Where(r => r.RentableObject.Id == id))
                {                    
                    for (DateTime date = item.BookedFrom; date <= item.BookedTo; date = date.AddDays(1))
                    {              
                        allDates.Add(date);                       
                    }
                }

                rental.BookedDates = allDates.ToArray();               
                rental.BookedFrom = DateTime.Today;
                rental.BookedTo = DateTime.Today;
                return View(rental);
            }
        }
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rental model)
        {
            using (var db = new UsersContext())
            {
                model.RentableObject = db.RentableObjects.Single(p => p.Id == model.RentableObject.Id);
                var span = model.BookedTo.Subtract(model.BookedFrom);
                int totalDays = Math.Abs(span.Days);

                if (model.RentableObject != null)
                    model.Payment = new Payment { Price = totalDays * model.RentableObject.Price };
                db.Rentals.Add(model);
                db.SaveChanges();
                return View(model);
            }
        }
    }
}
