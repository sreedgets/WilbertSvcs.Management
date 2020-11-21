using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Truck
    {
        public Truck()
        {
            Photos = new HashSet<Photo>();
        }

        public string TruckId { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public int PlantId { get; set; }
        public int? DriverEmployeeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string RegCounty { get; set; }
        public string Vin { get; set; }
        public int Tonnage { get; set; }
        public int LicPlateRenewal { get; set; }
        public decimal RegFee { get; set; }
        public long TruckNumber { get; set; }
        public bool Inactive { get; set; }
        public string InactiveReason { get; set; }

        public virtual Employee DriverEmployee { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
