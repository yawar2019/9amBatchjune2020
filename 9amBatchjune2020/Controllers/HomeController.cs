using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _9amBatchjune2020.Models;
namespace _9amBatchjune2020.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        public PartialViewResult getPartView()
        {
            return PartialView("_MyPartialView");
        }

        public ViewResult GetEmployee()
        {
            Employee obj = new Models.Employee();
            obj.EmpId = 1;
            obj.EmpName = "james";
            obj.Empsalary = 45670;
            return View(obj);
        }
    }
}