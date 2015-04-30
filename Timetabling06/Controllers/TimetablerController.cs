using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Timetabling06.Models;
using Timetabling06.ModelViews;
namespace Timetabling06.Controllers
{
    public class TimetablerController : Controller
    {
        private team06Entities db = new team06Entities();
        // GET: Timetabler
      
        public ActionResult Index()
        {
            ViewData["message"] = "timetable page";

            ViewBag.roomNumber = new SelectList(db.rooms, "roomNumber", "buildingCode");

            ViewBag.park = new SelectList(db.buildings, "code", "park");

            ViewBag.building = new SelectList(db.buildings, "code", "name");

            return View();
        }

        public ActionResult HandleForm(string park, string building, string roomNumber, string weeks)
        {
            ViewData["park"] = park;
            ViewData["building"] = building;
            ViewData["roomNumber"] = roomNumber;
            ViewData["weeks"] = weeks;

       return View("FormResults");
        }



        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
    
        }
            }


}
