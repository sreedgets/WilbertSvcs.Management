using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Delivery
    {
        public int DeliveryId { get; set; }
        public DateTime FuneralDate { get; set; }
        public string OrderingPlant { get; set; }
        public string DeliveringPlant { get; set; }
        public int VaultOrderId { get; set; }
        public string FuneralHome { get; set; }
        public string Cemetary { get; set; }
        public string FuneralDirector { get; set; }
        public DateTime GravesideTime { get; set; }
        public int DeceasedId { get; set; }
        public int Status { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Driver { get; set; }
        public string Truck { get; set; }
        public decimal AmtPaid { get; set; }
        public string PaidTo { get; set; }
        public int TruckNum { get; set; }
        public string EquipInNeedOfRepair { get; set; }
        public bool ReadyOnTime { get; set; }
        public bool AwningSet { get; set; }
        public bool EquipPolished { get; set; }
        public bool UniformClean { get; set; }
        public bool TentSet { get; set; }
        public bool ChairsSet { get; set; }
        public bool SideWalls { get; set; }
        public bool OilTiresChecked { get; set; }
        public string ReasonTentNotSet { get; set; }
        public string FdarrivalTime { get; set; }
        public string FdcommentsAndRemarks { get; set; }
        public DateTime TimeLeftPlant { get; set; }
        public int MilesTo { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime SetupTime { get; set; }
        public int ReturnTimeInMinutes { get; set; }
        public DateTime TimeInPlant { get; set; }
        public string RemarksOrProblems { get; set; }
        public bool ReviewedByOffice { get; set; }
    }
}
