using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MVCMongoDBMap.Models;


namespace MVCMongoDBMap.Controllers
{
     
    public class HomeController : Controller
    {
        private readonly LocationDB context = new LocationDB();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllLocation()
        {
               var location = context.Locations.FindAll().OrderBy(a => a.Title).ToList();
               return new JsonResult { Data = location, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetMarkerInfo(string locationID)
        {
            Location l = null;
            l = context.Locations.FindAll().Where(a=> a.LocationID.Equals(locationID)).FirstOrDefault();
            return new JsonResult { Data = l, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }

}
