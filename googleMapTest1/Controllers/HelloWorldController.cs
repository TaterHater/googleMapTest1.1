using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace googleMapTest1.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public ActionResult Index(float lat, float log)
        {
            ViewBag.lat = 0;
            ViewBag.log = 0;
            ViewBag.lat = lat;
            ViewBag.log = log;
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int ID = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = ID;
            return View();
        }
    }
}