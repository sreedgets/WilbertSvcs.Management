using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class VaultOrder
    {
        public VaultOrder()
        {
            DeliveringPlant = new HashSet<Plant>();
            OrderingPlant = new HashSet<Plant>();
            FuneralHomes = new HashSet<FuneralHome>();
            funeralhome = new FuneralHome();
            funeralhome.Contacts = new HashSet<FuneralHomeContact>();
            lstCemetaries = new HashSet<Cemetary>();
        }
        public int VaultOrderId { get; set; }

        [Display(Name = "Funeral Date/Time")]
        public DateTime FuneralDate { get; set; }

        [Display(Name = "Cemetery Time")]
        public DateTime CemetaryTime { get; set; }

        [Display(Name = "Funeral Location")]
        public string Location { get; set; }

        [Display(Name = "Grave Location Section")]
        public string GraveLocationSection { get; set; }

        [Display(Name = "Ordering Plant")]
        public int OrderingPlantId { get; set; }
        public virtual ICollection<Plant> OrderingPlant { get; set; }

        [Display(Name = "Delivering Plant")]
        public int DeliveringPlantId { get; set; }
        public virtual ICollection<Plant> DeliveringPlant { get; set; }

        public string ZipCode { get; set; }

        [Display(Name = "Funeral Home")]
        public int FuneralHomeId { get; set; }

        [Display(Name = "Funeral Home")]
        public FuneralHome funeralhome { get; set; }

        public virtual ICollection<FuneralHome> FuneralHomes { get; set; }
        public string NewFuneralHome { get; set; }

        [Display(Name = "FH Director")]
        public string FuneralDirector { get; set; }
        public string NewFuneralDirector { get; set; }

        [Display(Name = "Cemetery Name")]
        public int CemetaryId { get; set; }

        [Display(Name = "Order Status")]
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

        [Display(Name = "Order Notes")]
        public string Notes { get; set; }
        public int? PlantId { get; set; }
        public int DeceasedId { get; set; }
        public Deceased theDeceased { get; set; }
        [NotMapped]
        public virtual ICollection<Cemetary> lstCemetaries { get; set; }
    }
}
