using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarrierSearchInc.Models
{
    public enum Industries
    {
        //Technology,Agriculture,Banking,OilandGas
        [Display (Name ="Technlogy")]
        Technology,
        [Display (Name = "Agriculture")]
        Agriculture,
        [Display (Name = "Banking")]
        Banking,
        [Display (Name = "Oil and Gas")]
        Oil_and_Gas,
        [Display (Name = "Telecommunication")]
        Telecommunication,
        [Display (Name = "Sports")]
        Sports
    }
}
