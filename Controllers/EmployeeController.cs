using Inteface_Dependency.DAL;
using Inteface_Dependency.IEmployeeInterface;
using Inteface_Dependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inteface_Dependency.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployee repos;
        public  EmployeeController(IEmployee repo)
        {
            repos= repo;
        }
        public ActionResult Index()
        {
          List<Employee> emp = repos.GetEmployees();
            return View(emp);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            repos.AddEmployee(emp);
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult Delete(string s)
        {
            
            repos.DeleteEmployee(s);
            return RedirectToAction("Index");
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            repos.EditEmployee(emp);
            return RedirectToAction("Index");
        }

    }
}