using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OData.Edm;

namespace CarrierSearchInc.Models
{
    public class ICT
    {
        public string Position { get; set; }
        public string Employer { get; set; }

        public string SalaryRange { get; set; }

        public Date PostedDate { get; set; }

        public Date CloseDate { get; set; }

        public string Section = "ICT";
    }
}
