using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_ViewData_In_MVC.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            TempData["Data"] = "Data from index method";
            return View();
        }
        public ActionResult Index2()
        {
            //Session.Abandon(); //tempdata internally use session 
            ViewBag.Mykey = TempData.Peek("Data");
            //TempData.Keep("Data"); // for reserve data for next request using keep method
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.Mykey = TempData["Data"];
            return View();
        }
    }
}