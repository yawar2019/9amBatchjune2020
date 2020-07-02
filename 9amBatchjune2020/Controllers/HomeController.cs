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

        public RedirectResult GotoGoogle()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult GotoSomeViewTemp()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult GotoSomeViewPermenant()
        {
            return RedirectPermanent("http://www.google.com");
        }
        public RedirectToRouteResult GoBasedOnRoute()
        {
            return RedirectToRoute("Myhotel");
        }

        public JsonResult GetJsonResult()
        {
            Employee obj = new Models.Employee();
            obj.EmpId = 1;
            obj.EmpName = "james";
            obj.Empsalary = 45670;

            Employee obj1 = new Models.Employee();
            obj1.EmpId = 2;
            obj1.EmpName = "Tom";
            obj1.Empsalary = 323423;

            List<Employee> objlist = new List<Employee>();
            objlist.Add(obj);
            objlist.Add(obj1);
            return Json(objlist,JsonRequestBehavior.AllowGet);
        }

        public FileResult getFileTextFormat() {
            return File("~/Web.config", "text");
        }
        public FileResult getFileXmlFormat()
        {
            return File("~/Web.config", "application/xml");
        }

        public FileResult getFilePdfFormat()
        {
            return File("~/Content/HtmlPage1.html", "text");
        }
        public FileResult getFileDownloaded()
        {
            return File("~/Web.config", "application/xml", "Web.config");
        }

        public ContentResult ShowContent(int?id) {
            if (id == 1)
            {
                return Content("<p style=color:red; font-family:italic;>Hello world</p>");
            }
            else if (id == 2)
            {
                return Content("<script> alert('great to watch')</script>");
            }
            else
            {
                return Content("got it");
            }

        } 

        public ActionResult ValidationExample()
        {
            ServiceReference1.WCFServiceExampleClient obj = new ServiceReference1.WCFServiceExampleClient();
            obj.Add(12, 15);
            return Content(obj.Add(12, 15).ToString());
        }

    }
}