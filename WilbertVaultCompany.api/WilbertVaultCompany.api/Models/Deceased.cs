using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Deceased
    {
        public int DeceasedId { get; set; }

        [Display(Name = "Deceased Salutation")]
        public string Salutation { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public string Suffix { get; set; }

        [Display(Name = "Born")]
        public DateTime BornDate { get; set; }


        [Display(Name = "Died")]
        public DateTime DiedDate { get; set; }
    }
}
