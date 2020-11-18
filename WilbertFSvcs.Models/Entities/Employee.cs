using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WilbertFSvcs.Models.Enums;
using WilbertFSvcs.Models.Misc;

namespace WilbertFSvcs.Models.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int PlantId { get; set; }

        [ForeignKey("PlantId")]
        public Plant EmployeePlant { get; set; }
        public Boolean CanDoFollowUps { get; set; }
        public PlantRole Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public List<Phone> PhNumbers { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public Boolean Active { get; set; }
        public byte[] PhotoImage { get; set; }
    }
}
