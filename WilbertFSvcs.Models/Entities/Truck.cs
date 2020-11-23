using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WilbertFSvcs.Models.Enums;
using WilbertFSvcs.Models.Misc;

namespace WilbertFSvcs.Models.Entities
{
    public class Truck
    {
        public string TruckId { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public int PlantId { get; set; }

        [ForeignKey("PlantId")]
        public Plant AssignedPlant { get; set; }
        public Employee Driver { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string RegCounty { get; set; }
        public string VIN { get; set; }
        public int Tonnage { get; set; }
        public LicDue LicPlateRenewal { get; set; }
        public decimal RegFee { get; set; }
        public long TruckNumber { get; set; }
        public Boolean Inactive { get; set; }
        public string InactiveReason { get; set; }
        public List<Photo> Photos { get; set; }

    }
}
