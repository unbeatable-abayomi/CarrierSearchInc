using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OData.Edm;

namespace CarrierSearchInc.Models
{
    public class PostJobs
    {
        public string CompanyName { get; set; }

        public string Role { get; set; }
        public string Industry { get; set; }

        public IEnumerable<Industry> AllIndustries { get; set; }
        public string FunctionalArea { get; set; }

        public IEnumerable<FunctionalArea> AllfunctionalAreas { get; set; }

        public string Experience { get; set; }

        public IEnumerable<Experience> AllExperiences { get; set; }

        public string Qualification { get; set; }

        public IEnumerable<Qualification> AllQualifications { get; set; }

        public Date PostDate { get; set; }

        public Date CloseDate { get; set; }
    }
}
