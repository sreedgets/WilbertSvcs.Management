using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Deceased
    {
        public int DeceasedId { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Suffix { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime DiedDate { get; set; }
    }
}
