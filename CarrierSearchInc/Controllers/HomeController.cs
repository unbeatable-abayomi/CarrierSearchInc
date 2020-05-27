using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarrierSearchInc.Models;

namespace CarrierSearchInc.Controllers
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
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Profile()
        {
            List<Profiles> profiles = new List<Profiles>()
            {
                new Profiles(){CompanyName="Nike",Country="USA",NumberInterviewed=123,NumberEmployeed=92,DateOfLastEmployment="5/25/2020"},
              new Profiles  {CompanyName="Bently",Country="Germany",NumberInterviewed=153,NumberEmployeed=82,DateOfLastEmployment="5/23/2020"},
               new Profiles  {CompanyName="Gucci",Country="Italy",NumberInterviewed=103,NumberEmployeed=80,DateOfLastEmployment="5/21/2020"},

            new Profiles { CompanyName = "Puma", Country = "USA", NumberInterviewed = 113, NumberEmployeed = 40, DateOfLastEmployment = "5/19/2020" },
            new Profiles { CompanyName = "Jaguar", Country = "Sweden", NumberInterviewed = 93, NumberEmployeed = 35, DateOfLastEmployment = "5/15/2020" }
            };
            return View(profiles);
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
