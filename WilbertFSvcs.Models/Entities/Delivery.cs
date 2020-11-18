using System;
using System.ComponentModel.DataAnnotations.Schema;
using WilbertFSvcs.Models.Enums;

namespace WilbertFSvcs.Models.Entities
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public DateTime FuneralDate { get; set; }
        public string OrderingPlant{ get; set; }
        public string DeliveringPlant { get; set; }

        public int VaultOrderId { get; set; }
        
        [ForeignKey("VaultOrderId")]
        public VaultOrder Order { get; set; }

        public string FuneralHome { get; set; }
        public string Cemetary { get; set; }
        public string FuneralDirector { get; set; }
        public DateTime GravesideTime { get; set; }
        public int DeceasedId { get; set; }
        
        [ForeignKey("DeceasedId")]
        public Deceased theDeceased { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Driver { get; set; }
        public string Truck { get; set; }
        public decimal  AmtPaid { get; set; }
        public string PaidTo { get; set; }
        public int TruckNum { get; set; }
        public string EquipInNeedOfRepair { get; set; }
        public Boolean ReadyOnTime { get; set; }
        public Boolean AwningSet { get; set; }
        public Boolean EquipPolished { get; set; }
        public Boolean UniformClean { get; set; }
        public Boolean TentSet { get; set; }
        public Boolean ChairsSet { get; set; }
        public Boolean SideWalls { get; set; }
        public Boolean OilTiresChecked { get; set; }
        public string ReasonTentNotSet { get; set; }
        public string FDArrivalTime { get; set; }
        public string FDCommentsAndRemarks { get; set; }
        
        //Format - HH:MM AM/PM
        public DateTime TimeLeftPlant { get; set; }
        public int MilesTo { get; set; }
        //Format - HH:MM AM/PM
        public DateTime ArrivalTime { get; set; }
        //Format - HH:MM AM/PM
        public DateTime SetupTime { get; set; }
        public int ReturnTimeInMinutes { get; set; }
        //Format - HH:MM AM/PM
        public DateTime TimeIn_Plant { get; set; }
        public string RemarksOrProblems { get; set; }
        public Boolean ReviewedByOffice { get; set; }
    }
}
