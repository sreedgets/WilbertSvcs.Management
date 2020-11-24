using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Plant
    {
        public Plant()
        {
            Employees = new HashSet<Employee>();
            FuneralHomes = new HashSet<FuneralHome>();
            //Phones = new HashSet<Phone>();
            Trucks = new HashSet<Truck>();
            VaultOrders = new HashSet<VaultOrder>();
        }

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantManagerEmail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public bool PrintCompletedOrders { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<FuneralHome> FuneralHomes { get; set; }
        //public virtual ICollection<Phone> Phones { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone1 { get; set; }
        public string PhoneType1 { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone2 { get; set; }
        public string PhoneType2 { get; set; }

        public virtual ICollection<Truck> Trucks { get; set; }
        public virtual ICollection<VaultOrder> VaultOrders { get; set; }
    }
}
