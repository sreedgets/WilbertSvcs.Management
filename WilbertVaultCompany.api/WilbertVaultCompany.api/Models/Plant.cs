using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Plant
    {
        public int PlantId { get; set; }

        [Display(Name = "Plant Name")]
        public string PlantName { get; set; }

        [Display(Name = "Plant Manager Email")]
        public string PlantManagerEmail { get; set; }

        [Display(Name = "Plant Manager Txt Num")]
        public string PlantManagerTxtNum { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        
        [Display(Name = "Print Completed Orders")]
        public bool PrintCompletedOrders { get; set; }

        [Display(Name = "Phone")]
        public string Phone1 { get; set; }

        [Display(Name = "Phone")]
        public string Phone2 { get; set; }
        public string PhoneType1 { get; set; }
        public string PhoneType2 { get; set; }

        public virtual FuneralHome PlantNavigation { get; set; }
    }
}
