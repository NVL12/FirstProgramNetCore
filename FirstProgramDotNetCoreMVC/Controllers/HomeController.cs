using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSP;

namespace FirstProgramDotNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeManage _employeeManage;

        public HomeController(IEmployeeManage employeeManage)
        {
            _employeeManage = employeeManage;
        }

        
        public ViewResult Index()
        {
            return View();
        }        
        
        [HttpPost]
        public ViewResult Notification(Employee e)
        {
            if (ModelState.IsValid)
            {                
                e.Name = Request.Form["Name"];
                e.Salary = Convert.ToDouble(Request.Form["Salary"]);
                double totalSalary = _employeeManage.TotalSalary(e);
                ViewBag.totalSalary = totalSalary;
                return View(e);
            }
            else
                return View("Index");
        }
        
    }
}
