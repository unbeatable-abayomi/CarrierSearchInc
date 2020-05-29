using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarrierSearchInc.Models
{
    public class SignUp
    {
      
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public Date DateOfBirth { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
