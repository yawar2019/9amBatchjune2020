using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller,IActionFilter
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpName=frm["EmpName"];
            obj.EmpSalary = Convert.ToInt32(frm["EmpSalary"]);
            
            db.EmployeeModels.Add(obj);
            int i = db.SaveChanges();
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
        public ActionResult Edit(int? id)
        {
            EmployeeModel obj = db.EmployeeModels.Find(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel obj)
        {

            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            
            int i = db.SaveChanges();
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
        public ActionResult Delete(int? id)
        {
            EmployeeModel obj = db.EmployeeModels.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel obj = db.EmployeeModels.Find(id);
            db.EmployeeModels.Remove(obj);

            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}