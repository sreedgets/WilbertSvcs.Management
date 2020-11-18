using System;
using System.Security.Cryptography;
using System.Security.Principal;

namespace WilbertFSvcs.Models.Entities
{
    public class Deceased
    {
        public int DeceasedId { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Suffix suffix { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime DiedDate { get; set; }
    }
}