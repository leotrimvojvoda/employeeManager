using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Emanager01.Models;
using Emanager01.Data;
using System.Threading;

namespace Emanager01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("INDEX");

           

            return View();
        }

        public IActionResult Privacy()
        {
            Console.WriteLine("PRIVACY");
            return View();
        }

        [HttpPost]
        public ActionResult Login(Manager manager)
        {

            
             if (ModelState.IsValid)
             {

               
                 ManagerQuerry managerQuerry = new ManagerQuerry();

                 if (manager != null)
                 {
                     Manager tempManager = managerQuerry.getManagerByEmail(manager.Email);

                     if (tempManager != null)
                     {

                         if (manager.Password == tempManager.Password)
                         {

                            EmployeeQuerry querry = new EmployeeQuerry();


                            return View(querry.getAllEmployees());
                         }
                         else
                         {
                             return View("Index",manager);
                         }
                     }
                 }


             }
             else
             {
                 Console.WriteLine("Model state invalid");
                 return View("Index");
             }

           return View("Index");

        }

        public IActionResult dashboard()
        {
            EmployeeQuerry querry = new EmployeeQuerry();


            return View("Login",querry.getAllEmployees());
        }


        
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
