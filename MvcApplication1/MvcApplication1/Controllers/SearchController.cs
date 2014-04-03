using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MvcApplication1.Models;
using System.Data.Entity;

namespace MvcApplication1.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult SearchResult()
        {
            return View();
        }

        public ActionResult Index(string searchWord,string objectType,string sizeSqm,string price)
        {
            using (var db = new UsersContext())
            {

                var housing = from h in db.RentableObjects select h;
                housing = housing.Where(s => s.Available); 
                if (!string.IsNullOrEmpty(searchWord))
                {
                    
                        housing = housing.Where(s => s.Title.Contains(searchWord));
                    
                }
                if (!string.IsNullOrEmpty(objectType))
                {
                    housing = housing.Where(s => s.ObjectType.Contains(objectType));
                }
                if (!string.IsNullOrEmpty(sizeSqm))
                {
                    var size = int.Parse(sizeSqm);
                    housing = housing.Where(s => size < s.SizeSqm);
                }
                if (!string.IsNullOrEmpty(price))
                {
                    var highestprice = int.Parse(price);
                    housing = housing.Where(s => highestprice > s.Price);
                }

                return View(housing.Include("Picture").Take(50).ToList());
            }
            
        }
    


    }
}
