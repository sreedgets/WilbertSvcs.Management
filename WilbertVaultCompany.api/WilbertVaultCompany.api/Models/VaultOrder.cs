using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class VaultOrder
    {
        public VaultOrder()
        {
            Deliveries = new HashSet<Delivery>();
        }

        public int VaultOrderId { get; set; }
        public DateTime FuneralDate { get; set; }
        public DateTime FuneralTime { get; set; }
        public DateTime CemetaryTime { get; set; }
        public int Location { get; set; }
        public string OrderingPlant { get; set; }
        public string DeliveringPlant { get; set; }
        public string FuneralHome { get; set; }
        public string NewFuneralHome { get; set; }
        public string FuneralDirector { get; set; }
        public string NewFuneralDirector { get; set; }
        public int CemetaryId { get; set; }
        public int Status { get; set; }
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
        public int DeceasedId { get; set; }

        public virtual Cemetary Cemetary { get; set; }
        public virtual Deceased Deceased { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual Vault Vault { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
