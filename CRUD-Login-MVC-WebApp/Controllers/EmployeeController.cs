using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CRUD_Login_MVC_WebApp.Models;

namespace CRUD_Login_MVC_WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        DbServicesContext db = new DbServicesContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.tbl_emp.ToList());
        }
    }
}