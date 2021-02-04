using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Truck
    {
        [Display(Name = "Plate Number")]
        [Required]
        public string TruckId { get; set; }
   
        [Display(Name = "Acquisition Date")]
        public DateTime AcquisitionDate { get; set; }
               
        public int? DriverEmployeeId { get; set; }

        public string DriverName { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public string Type { get; set; }

        [Display(Name = "Reg County")]
        public string RegCounty { get; set; }

        [Display(Name = "VIN")]
        public string Vin { get; set; }

        public int Tonnage { get; set; }

        [Display(Name = "Month License Due")]
        public string LicPlateRenewal { get; set; }

        [Display(Name = "Reg fee")]
        public decimal RegFee { get; set; }

        [Display(Name = "Truck Number")]
        public long TruckNumber { get; set; }

        [Display(Name = "Vehicle Inactive?")]
        public bool Inactive { get; set; }

        [Display(Name = "Reason inactove")]
        public string InactiveReason { get; set; }

        [NotMapped]
        public  List<Plant> Plants { get; set; }


        /********************************************************************/

        [Range(1, 999, ErrorMessage = "Please select a plant")]
        public int PlantId { get; set; }

        [Display(Name = "Assigned Plant")]
        public virtual Plant AssignedPlant { get; set; }

    }
}
