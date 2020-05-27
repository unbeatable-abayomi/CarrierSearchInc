using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrierSearchInc.Models
{
    public class WalkInInterviews
    {
        public List<MondayInterviews> MondayInterviews = new List<MondayInterviews>()
        {
            new MondayInterviews (){Employer="Global Com",Category="ICT",Position="Frontend Developer",Qualifactions="Bsc,Msc",YearsOfExpericence ="2 years",DateOfInterview="25/05/2020",TimeOfInterview="10am"},
            new MondayInterviews (){Employer="Nokia",Category="Finance",Position="Accountant",Qualifactions="Bsc,Ican,Acca",YearsOfExpericence ="5 years",DateOfInterview="25/05/2020",TimeOfInterview="11am"},
            new MondayInterviews (){Employer="SDSD",Category="ICT",Position="Backend Developer",Qualifactions="Bsc",YearsOfExpericence ="2 years",DateOfInterview="25/05/2020",TimeOfInterview="12noon"},
            new MondayInterviews (){Employer="Puma",Category="Administration",Position="Regional Manager(Europe)",Qualifactions="Msc Business Administartion",YearsOfExpericence ="4 years",DateOfInterview="25/05/2020",TimeOfInterview="2pm"}
        };
        public List<WednesdayInterviews> wednesdayInterviews = new List<WednesdayInterviews>()
        {
            new WednesdayInterviews (){Employer="Greens Fied Int'l",Category="Marketing",Position="Marketing Manager",Qualifactions="Bsc Marketing,Msc Business Adminstrtion",YearsOfExpericence ="2 years",DateOfInterview="27/05/2020",TimeOfInterview="9am"},
            new WednesdayInterviews (){Employer="Intel Co-Operation Int'l",Category="Finance",Position="Accountant",Qualifactions="Bsc Accouting/Acca",YearsOfExpericence ="5 years",DateOfInterview="27/05/2020",TimeOfInterview="10am"},
            new WednesdayInterviews (){Employer="Stripe Communcations",Category="ICT",Position="Andorid Developer",Qualifactions="Bsc Comp Science",YearsOfExpericence ="3 years",DateOfInterview="27/05/2020",TimeOfInterview="12noon"},
            new WednesdayInterviews (){Employer="SoftCom",Category="ICT",Position="Team Lead(Frontend)",Qualifactions="Msc Comp Sceince",YearsOfExpericence ="5 years",DateOfInterview="27/05/2020",TimeOfInterview="2pm"}
        };
        public List<FridayInterviews> fridayInterviews = new List<FridayInterviews>()
        {
            new FridayInterviews  (){Employer="North Switch",Category="ICT",Position="DevOps",Qualifactions="Msc Comp Sceince",YearsOfExpericence ="5 years",DateOfInterview="29/05/2020",TimeOfInterview="1pm"},
            new FridayInterviews  (){Employer="Telegram",Category="ICT",Position="UI/UX Designer",Qualifactions="Bsc",YearsOfExpericence ="2 years",DateOfInterview="29/05/2020",TimeOfInterview="2pm"},
                new FridayInterviews  (){Employer="FlutterWave",Category="ICT",Position="(Lead)UI/UX Designer",Qualifactions="Bsc",YearsOfExpericence ="4 years",DateOfInterview="29/05/2020",TimeOfInterview="3pm"}
        };
    }
}
