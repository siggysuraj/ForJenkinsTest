using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForJenkins.Models;

namespace ForJenkins.Controllers
{
    public class HomeController : Controller
    {
        [NonAction]

        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>{
            new Employee{
               ID = 1,
               Name = "Allan",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 23
            },

            new Employee{
               ID = 2,
               Name = "Carson",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 45
            },

            new Employee{
               ID = 3,
               Name = "Carson",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 37
            },

            new Employee{
               ID = 4,
               Name = "Laura",
               JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
               Age = 26
            },
         };
        }

        // GET: Employee
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            var employees = from e in GetEmployeeList()
                            orderby e.ID
                            select e;
            return View(employees);
        }
    
   

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
