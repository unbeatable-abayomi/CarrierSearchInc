using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarrierSearchInc.Models;
using CarrierSearchInc.Services;
using System.Collections;

namespace CarrierSearchInc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private WalkinInterviewsService walkInInterviews;
        private TopJobsService topJobs;

        public HomeController(ILogger<HomeController> logger, WalkinInterviewsService walkin, TopJobsService jobs)
        {
            _logger = logger;
          
            this.walkInInterviews = walkin;
            this.topJobs = jobs;

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


        public IActionResult WalkIn()
        {
            //WalkInInterviews walkInInterviews = new WalkInInterviews();
            List<MondayInterviews> mondayInterviews = walkInInterviews.GetMondayInterviews();
            List<WednesdayInterviews> wednesdayInterviews = walkInInterviews.GetWednesdayInterviews();
            List<FridayInterviews> fridayInterviews = walkInInterviews.GetFridayInterviews();


            ArrayList interviews = new ArrayList() { mondayInterviews, wednesdayInterviews,fridayInterviews };
            return View(interviews);
        }

        public IActionResult TopJobs()
        {
            WalkInInterviews walkInInterviews = new WalkInInterviews();

            List<Finance> financesTopJobs = topJobs.GetFinancesJobs();
            List<ICT> iCTsTopJobs = topJobs.GetICTJobs();
            List<Marketing> marketings = topJobs.GetMarketingsJobs();

            ArrayList allTopJobs = new ArrayList() { financesTopJobs,iCTsTopJobs,marketings };

            return View(allTopJobs);
        }

        public IActionResult PostJobs()
        {
            PostJobs postJobs = new PostJobs() {
                //AllIndustries = Enum.GetValues(typeof(FunctionalArea)).Cast<Industry>().ToList(),
                //AllfunctionalAreas = Enum.GetValues(typeof(FunctionalArea)).Cast<FunctionalArea>().ToList(),
                //AllQualifications = Enum.GetValues(typeof(Qualification)).Cast<Qualification>().ToList()
                //AllExperiences = Enum.GetValues(typeof(Experience)).Cast<Experience>().ToList()
            };

            return View(postJobs);
        }

        public IActionResult LoginView(Login login)
        {
            return View();
        }

        public IActionResult SignupView(SignUp signUp )
        {

            return View();
        }
        public IActionResult FAQs()
        {
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
