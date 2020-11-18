using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WilbertFSvcs.Models.Enums;

namespace WilbertFSvcs.Models.Entities
{
    public class VaultOrder
    {
        public int VaultOrderId { get; set; }
        public DateTime FuneralDate { get; set; }
        public DateTime FuneralTime { get; set; }
        public DateTime CemetaryTime { get; set; }
        public FuneralLocation Location { get; set; }
        public string OrderingPlant { get; set; }
        public string DeliveringPlant { get; set; }
        public string funeralHome { get; set; }
        public string newFuneralHome { get; set; }
        public string funeralDirector { get; set; }
        public string newFuneralDirector { get; set; }


        public int CemetaryId { get; set; }
        [ForeignKey("CemetaryId")]
        public Cemetary cemetary { get; set; }
        public OrderStatus Status { get; set; }


        public int DeceasedId { get; set; }
        [ForeignKey("DeceasedId")]
        public Deceased deceased { get; set; }


        public Category category { get; set; }
        public Vault vault { get; set; }
        public VenetianCarapace VenetianCarapace { get; set; }
        public Boolean TentWith6Chairs { get; set; }
        public int ExtraChairs { get; set; }
        public Boolean RegisterStand { get; set; }
        public Boolean MilitarySetup { get; set; }
        public Boolean AwningOverCasket { get; set; }
        public string FDRequest { get; set; }
        public string Notes { get; set; }
    }
}
