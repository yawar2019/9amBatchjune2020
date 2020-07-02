using AdoExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Employeeinfo obj = new Employeeinfo();
        public ActionResult Index()
        {
             
            return View(obj.getEmployee());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee objemp)
        {
            int i = obj.SaveEmployee(objemp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            Employee objemp = obj.getEmployeeById(Id);
            return View(objemp);
        }
        [HttpPost]
        public ActionResult Edit(Employee objemp)
        {
            int i = obj.UpdateEmployee(objemp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            Employee objemp = obj.getEmployeeById(Id);
            return View(objemp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? Id)
        {
            int i = obj.DeleteEmployee(Id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }
        public ActionResult HtmlHelperExample()
        {
            Employee obj1 = new Models.Employee();
            obj1.EmpId = 1;
            obj1.EmpName = "Prashant";
            obj1.EmpSalary = 25000;

            ViewBag.Employee = new SelectList(obj.getEmployee(), "EmpId", "EmpName");

            return View(obj1);

        }

        public ActionResult GetMyService()
        {
            ServiceReference1.MyServiceSoapClient obj = new ServiceReference1.MyServiceSoapClient();

            return Content(obj.Add(2,4).ToString());
        }
    }
}