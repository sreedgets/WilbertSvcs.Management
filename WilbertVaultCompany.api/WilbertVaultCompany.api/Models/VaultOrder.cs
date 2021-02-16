using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class VaultOrder
    {
        public int VaultOrderId { get; set; }
        public DateTime FuneralDate { get; set; }
        public DateTime FuneralTime { get; set; }
        public DateTime CemetaryTime { get; set; }
        public string Location { get; set; }
        public string GraveLocation { get; set; }
        public virtual ICollection<Plant> OrderingPlant { get; set; }

        public virtual ICollection<Plant> DeliveringPlant { get; set; }

        public string ZipCode { get; set; }
        
        public FuneralHome FH { get; set; }
        public virtual ICollection<FuneralHome> FuneralHomes { get; set; }
        public string NewFuneralHome { get; set; }
        public string FuneralDirector { get; set; }
        public string NewFuneralDirector { get; set; }
        public int CemetaryId { get; set; }
        public string Status { get; set; }
        public int Category { get; set; }
        public int? VaultId { get; set; }
        public int VenetianCarapace { get; set; }
        public bool TentWith6Chairs { get; set; }
        public int ExtraChairs { get; set; }
        public bool RegisterStand { get; set; }
        public bool MilitarySetup { get; set; }
        public bool AwningOverCasket { get; set; }
        public string Fdrequest { get; set; }
        public string Notes { get; set; }
        public int? PlantId { get; set; }
        public virtual ICollection<Deceased> lstDecesased { get; set; }
        public virtual ICollection<Cemetary> lstCemetaries { get; set; }
    }
}
