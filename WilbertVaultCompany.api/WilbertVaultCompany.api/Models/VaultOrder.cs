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
            //funeralhome = new FuneralHome();
            Contacts = new HashSet<FuneralHomeContact>();
            lstCemetaries = new HashSet<Cemetary>();
        }
 

        public int VaultOrderId { get; set; }

        
        [Display(Name = "Funeral Date/Time")]        
        public string strFuneralDate { get; set; }
        
        
        [Display(Name = "Funeral Date/Time")] 
        public DateTime FuneralDate { get; set; }

        
        [Display(Name = "Cemetery Time")]
        public DateTime CemetaryTime { get; set; }

        
        [Display(Name = "Cemetery Time")] 
        public string strCemeteryTime { get; set; }
        
        
        [Display(Name = "Funeral Location")]
        public string Location { get; set; }

        
        [Display(Name = "Grave Location Section")]
        public string GraveLocationSection { get; set; }

        /*****************************************************/

        [Display(Name = "Ordering Plant")]
        public int OrderingPlantId { get; set; }
        [Display(Name = "Ordering Plant")] 
        public string OrderingPlantName { get; set; }
        public virtual ICollection<Plant> OrderingPlant { get; set; }

        /*****************************************************/

        [Display(Name = "Delivering Plant")]
        public int DeliveringPlantId { get; set; }
        public string DeliveringPlantName { get; set; }
        public virtual ICollection<Plant> DeliveringPlant { get; set; }

        public string ZipCode { get; set; }

        /*****************************************************/

        [Display(Name = "Funeral Home")]
        public int FuneralHomeId { get; set; }        
        public string funeralhome { get; set; }
        public virtual ICollection<FuneralHome> FuneralHomes { get; set; }

        /*****************************************************/

        [Display(Name = "FH Director")]
        public int FuneralHomeContactId { get; set; }
        public string FuneralDirector { get; set; }
        public virtual ICollection<FuneralHomeContact> Contacts { get; set; }
        
        /*****************************************************/

        [Display(Name = "Cemetery Name")]
        public int CemetaryId { get; set; }
        public string CemetaryName { get; set; }
        public virtual ICollection<Cemetary> lstCemetaries { get; set; }

        /*****************************************************/

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
        
        public string Salutation { get; set; }
        
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }
        
        public string FullName { get; set; }
        
        public string Suffix { get; set; }
        
        public DateTime BornDate { get; set; }
        
        public DateTime DiedDate { get; set; }        
    }
}
