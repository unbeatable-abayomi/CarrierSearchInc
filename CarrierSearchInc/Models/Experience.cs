using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarrierSearchInc.Models
{
    public enum Experience
    {
       [Display (Name =  "One Year")]
       ONE_YEAR,
       [Display (Name = "Two Years")]
       TWO_YEARS,
        [Display(Name = "Three Years")]
        THREE_YEARS,
        [Display(Name = "Four Years")]
        FOUR_YEARS,
        [Display(Name = "Five Years")]
        FIVE_YEARS,
        [Display(Name = "Five Years and Above")]
        ABOVE_FIVE_YEARS

    }
}
