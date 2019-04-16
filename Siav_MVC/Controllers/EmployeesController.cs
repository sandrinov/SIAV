using Siav_MVC.Models;
using Siav_MVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Siav_MVC.Controllers
{
    public class EmployeesController : Controller
    {
        private IRepository _rep;
        public EmployeesController()
        {
            _rep = new EFRepository();
        }
        // GET: Employees
        public ActionResult Index()
        {

            return View(_rep.getAllEmployees());
        }
        public ActionResult Create()
        {

            return View();
        }

        public ActionResult TestJQuery()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DTO_Employee employee)
        {

            if (ModelState.IsValid)
            {
                _rep.NewEmployee(employee);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Error inserting");
            }
            return View();
        }
    }
}