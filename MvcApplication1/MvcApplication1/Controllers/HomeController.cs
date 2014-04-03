using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new UsersContext())
            {
                var list = new List<Picture>();
                if (db.Pictures.Count() > 0)
                {

                    foreach (var item in db.RentableObjects.Include("Picture").Where(r => r.Available == true))
                    {
                        if (item.Picture.Count() > 1)
                            list.Add(item.Picture.FirstOrDefault(p => p.RentableObject.Id == item.Id));
                        else
                            list.Add(item.Picture.SingleOrDefault(p => p.RentableObject.Id == item.Id));
                    }
                    return View(list.Take(5));
                    
                }
                else
                    return View(list);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
