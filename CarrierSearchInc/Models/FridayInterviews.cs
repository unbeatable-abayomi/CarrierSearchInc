using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrierSearchInc.Models
{
    public class FridayInterviews
    {
        public string Employer { get; set; }
        public string Category { get; set; }
        public string Position { get; set; }

        public string Qualifactions { get; set; }
        public string YearsOfExpericence { get; set; }

        public Date DateOfInterview { get; set; }
        public string TimeOfInterview { get; set; }
    }
}
