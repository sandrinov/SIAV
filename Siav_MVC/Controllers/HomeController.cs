using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Siav_MVC.Controllers
{
    public class MyClass
    {
        public int MyProperty { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["key"] = "Value";
            ViewBag.Message = "Your application description page.";
            MyClass mc = new MyClass() { MyProperty = 1};
            ViewBag.Obj = mc;
           return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}