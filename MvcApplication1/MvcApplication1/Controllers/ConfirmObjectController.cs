using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ConfirmObjectController : Controller
    {
        //
        // GET: /ConfirmObject/

        public ActionResult Index()
        {
            using (var db = new UsersContext())
            {
                var list = new List<RentableObject>();
                foreach (var item in db.RentableObjects.Include("Picture").Where(r=>r.Available==false))
                {
                    list.Add(item);
                }
                return View(list);
            }
        }

        public ActionResult Create(RentableObject obj)
        {
            using (var db = new UsersContext())
            {
                if (obj != null)
                {                 
                        var stud = (from s in db.RentableObjects
                                    where s.Id == obj.Id
                                    select s).FirstOrDefault();

                        stud.Available = obj.Available;

                       int num = db.SaveChanges();
                       return RedirectToAction("Index");
                }
                    return RedirectToAction("Index", "Home");
            }        
        }
    }
}
