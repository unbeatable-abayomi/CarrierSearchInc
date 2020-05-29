using CarrierSearchInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OData.Edm;
using System.Security.Cryptography.X509Certificates;

namespace CarrierSearchInc.Services
{
    public class TopJobsService
    {
        public List<Finance> Finances { get; set; } = new List<Finance>();

        public List<Finance> GetFinancesJobs()
        {
            Finances.Add(new Finance() { Position = "Accountant", Employer = "Stanbic Bank", SalaryRange = "$35,000-$45,000", PostedDate = Date.Now, CloseDate = Date.Parse("05/29/2020") });
            Finances.Add(new Finance() { Position = "Financial Secetary", Employer = "Eco Bank", SalaryRange = "$15,000-$25,000", PostedDate = Date.Now, CloseDate = Date.Parse("05/30/2020") });
            return Finances;
        }




        public List<Marketing> GetMarketingsJobs() 
        {
             List<Marketing> Marketings = new List<Marketing>()
            {
                new Marketing (){Position="Marketing Manager",Employer="Nokia Int'l", SalaryRange="$20,000-$30,000",PostedDate=Date.Parse("05/12/2020"),CloseDate=Date.Parse("05/17/2020")},
                 new Marketing (){Position="Marketing Personel",Employer="Sterling Bank", SalaryRange="$2000-$3000",PostedDate=Date.Parse("05/13/2020"),CloseDate=Date.Parse("05/18/2020")},
                    new Marketing (){Position="Head Marketing Africa",Employer="MicroSoft", SalaryRange="$40,000-$50,000",PostedDate=Date.Parse("05/14/2020"),CloseDate=Date.Parse("05/21/2020")},

            };  
            
            return Marketings;
        } 


        public List<ICT> GetICTJobs()
        {
            List<ICT> AlliCTs = new List<ICT>
            {
                  new ICT (){Position="Andorid Developer", Employer="Git Hub",SalaryRange="$55,000-$60,000",PostedDate=Date.Now,CloseDate=Date.Parse("05/31/2020")},
                   new ICT (){Position="Java Developer", Employer="FlutterWave",SalaryRange="$45,000-$50,000",PostedDate=Date.Now,CloseDate=Date.Parse("06/01/2020")}
            };
            return AlliCTs; 
        }
    }
}
