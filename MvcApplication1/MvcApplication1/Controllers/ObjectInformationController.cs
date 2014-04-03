using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ObjectInformationController : Controller
    {
        //
        // GET: /ObjectInformation/

        public ActionResult Index(int id)
        {
            using (var db = new UsersContext())
            {


                var rentObject = db.RentableObjects.Include("Picture").Single(b => b.Id == id);                                            
                return View(rentObject);

                

            }           
        }

    }
}