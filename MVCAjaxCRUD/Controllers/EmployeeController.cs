using MVCAjaxCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjaxCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllEmployee());
        }
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
        IEnumerable<Employee> GetAllEmployee()
        {
            using(MVCAjaxEntities db = new MVCAjaxEntities())
            {
                return db.Employees.ToList<Employee>();
            }
        }
    }
}