using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OData.Edm;
using CarrierSearchInc.Models;

namespace CarrierSearchInc.Services
{
    public class WalkinInterviewsService
    {
        public List<MondayInterviews> MondayInterviews { get; set; } = new List<MondayInterviews>();
        public List<MondayInterviews> GetMondayInterviews()
        {
            MondayInterviews.Add(new MondayInterviews() { Employer = "Global Com", Category = "ICT", Position = "Frontend Developer", Qualifactions = "Bsc,Msc", YearsOfExpericence = "2 years", DateOfInterview = "25/05/2020", TimeOfInterview = "10am" });
            MondayInterviews.Add(new MondayInterviews() { Employer = "Nokia", Category = "Finance", Position = "Accountant", Qualifactions = "Bsc,Ican,Acca", YearsOfExpericence = "5 years", DateOfInterview = "25/05/2020", TimeOfInterview = "11am" });
            MondayInterviews.Add(new MondayInterviews() { Employer = "SDSD", Category = "ICT", Position = "Backend Developer", Qualifactions = "Bsc", YearsOfExpericence = "2 years", DateOfInterview = "25/05/2020", TimeOfInterview = "12noon" });
            MondayInterviews.Add(new MondayInterviews() { Employer = "Puma", Category = "Administration", Position = "Regional Manager(Europe)", Qualifactions = "Msc Business Administartion", YearsOfExpericence = "4 years", DateOfInterview = "25/05/2020", TimeOfInterview = "2pm" });

            return MondayInterviews;
        }




        public List<WednesdayInterviews> GetWednesdayInterviews()
        {
            List<WednesdayInterviews> wednesdayInterviews = new List<WednesdayInterviews>()
            {
            new WednesdayInterviews (){Employer="Greens Fied Int'l",Category="Marketing",Position="Marketing Manager",Qualifactions="Bsc Marketing,Msc Business Adminstrtion",YearsOfExpericence ="2 years",DateOfInterview="27/05/2020",TimeOfInterview="9am"},
            new WednesdayInterviews (){Employer="Intel Co-Operation Int'l",Category="Finance",Position="Accountant",Qualifactions="Bsc Accouting/Acca",YearsOfExpericence ="5 years",DateOfInterview="27/05/2020",TimeOfInterview="10am"},
            new WednesdayInterviews (){Employer="Stripe Communcations",Category="ICT",Position="Andorid Developer",Qualifactions="Bsc Comp Science",YearsOfExpericence ="3 years",DateOfInterview="27/05/2020",TimeOfInterview="12noon"},
            new WednesdayInterviews (){Employer="SoftCom",Category="ICT",Position="Team Lead(Frontend)",Qualifactions="Msc Comp Sceince",YearsOfExpericence ="5 years",DateOfInterview="27/05/2020",TimeOfInterview="2pm"}
        };
            return wednesdayInterviews;
        }

        public List<FridayInterviews> GetFridayInterviews()
        {
              List<FridayInterviews> fridayInterviews = new List<FridayInterviews>()
            {
            new FridayInterviews  (){Employer="North Switch",Category="ICT",Position="DevOps",Qualifactions="Msc Comp Sceince",YearsOfExpericence ="5 years",DateOfInterview=Date.Parse("05/25/2020"),TimeOfInterview="1pm"},
            new FridayInterviews  (){Employer="Telegram",Category="ICT",Position="UI/UX Designer",Qualifactions="Bsc",YearsOfExpericence ="2 years",DateOfInterview=Date.Parse("05/25/2020"),TimeOfInterview="2pm"},
                new FridayInterviews  (){Employer="FlutterWave",Category="ICT",Position="(Lead)UI/UX Designer",Qualifactions="Bsc",YearsOfExpericence ="4 years",DateOfInterview=Date.Parse("05/25/2020"),TimeOfInterview="3pm"}
        };
            return fridayInterviews;
        }



        public List<Marketing> GetMarketings()
        {
              List<Marketing> marketings = new List<Marketing>()
        {
            new Marketing (){Position="Marketing Manager",Employer="Nokia Int'l", SalaryRange="$20,000-$30,000",PostedDate=Date.Parse("05/12/2020"),CloseDate=Date.Parse("05/17/2020")},
             new Marketing (){Position="Marketing Personel",Employer="Sterling Bank", SalaryRange="$2000-$3000",PostedDate=Date.Parse("05/13/2020"),CloseDate=Date.Parse("05/18/2020")},
              new Marketing (){Position="Head Marketing Africa",Employer="MicroSoft", SalaryRange="$40,000-$50,000",PostedDate=Date.Parse("05/14/2020"),CloseDate=Date.Parse("05/21/2020")},
        };
            return marketings;
        }



        //public List<Finance> Finances { get; set; } = new List<Finance>();
      
        //public List<Finance> GetFinances()
        //{
        //    Finances.Add(new Finance() { Position = "Accountant", Employer = "Stanbic Bank", SalaryRange = "$35,000-$45,000", PostedDate = Date.Now, CloseDate = Date.Parse("05/29/2020") });

        //    Finances.Add(new Finance() { Position = "Financial Secetary", Employer = "Eco Bank", SalaryRange = "$15,000-$25,000", PostedDate = Date.Now, CloseDate = Date.Parse("05/30/2020") });
           
        //    return Finances;

        //}

        //    public List<Finance> finances = new List<Finance>()
        //{
        //    new Finance (){Position="Accountant",Employer="Stanbic Bank", SalaryRange = "$35,000-$45,000",PostedDate=Date.Now,CloseDate=Date.Parse("05/29/2020")},
        //    new Finance (){Position="Financial Secetary",Employer="Eco Bank", SalaryRange = "$15,000-$25,000",PostedDate=Date.Now,CloseDate=Date.Parse("05/30/2020")}
        //};
        //    public List<ICT> iCTs = new List<ICT>()
        //{
        //    new ICT (){Position="Andorid Developer", Employer="Git Hub",SalaryRange="$55,000-$60,000",PostedDate=Date.Now,CloseDate=Date.Parse("05/31/2020")},
        //    new ICT (){Position="Java Developer", Employer="FlutterWave",SalaryRange="$45,000-$50,000",PostedDate=Date.Now,CloseDate=Date.Parse("06/01/2020")}
        //};
    }
}
