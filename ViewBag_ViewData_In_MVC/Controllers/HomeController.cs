using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_ViewData_In_MVC.Models;


namespace ViewBag_ViewData_In_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyCustomProperty = "Aniket Rana";

            ViewBag.List = new List<string>(){"Aniket", "Prem","Parth","Rohit"};

            List<Emp> empList = new List<Emp>()
            {
                new Emp(){ Email = "A@gmail.com",ID =1 ,Name ="Aniket"},
                new Emp(){ Email = "b@gmail.com",ID =2 ,Name ="Ankit"},
                new Emp(){ Email = "c@gmail.com",ID =3 ,Name ="abhi"},
                new Emp(){ Email = "d@gmail.com",ID =4 ,Name ="Rahul"},
                new Emp(){ Email = "e@gmail.com",ID =5 ,Name ="Yash"},
            };
            ViewBag.MyList = empList;

            return View();
        }

        public ActionResult demo()
        {
            ViewData["Data"] = "This is view data string";

            ViewData["Listdata"] = new List<string>() { "C++", "C#", "Python", "java" };

            return View();
        }
    }
}