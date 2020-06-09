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
    }
}