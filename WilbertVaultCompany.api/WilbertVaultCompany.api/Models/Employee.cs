﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Phones = new HashSet<Phone>();
            Trucks = new HashSet<Truck>();
        }

        public int EmployeeId { get; set; }
        public int PlantId { get; set; }
        public bool CanDoFollowUps { get; set; }
        public int Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public byte[] PhotoImage { get; set; }

        public virtual Plant Plant { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Truck> Trucks { get; set; }
    }
}