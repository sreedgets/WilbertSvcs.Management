using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class FuneralHome
    {
        public FuneralHome()
        {
            ParentFuneralHomes = new HashSet<ParentFuneralHome>();
            Plants = new HashSet<Plant>();
            Contacts = new HashSet<FuneralHomeContact>();
        }

        public int FuneralHomeId { get; set; }
        [Display(Name = "Parent Funeral Home")]
        public int? ParentFuneralHomeId { get; set; }

        [NotMapped]
        public string SearchTerm { get; set; }

        [Display(Name = "Plant")]
        public int? PlantId { get; set; }
        public int? FuneralHomeContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }

        [Display(Name = "Billing City")]
        public string BillingCity { get; set; }

        [Display(Name = "Billing State")]
        public string BillingState { get; set; }

        [Display(Name = "Billing Zip Code")]
        public string BillingZipCode { get; set; }
        public string County { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Website { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone1 { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone2 { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone3 { get; set; }

        public string PhoneType1 { get; set; }
        public string PhoneType2 { get; set; }
        public string PhoneType3 { get; set; }

        [Display(Name = "Parent Funeral Home?")]
        public bool IsParent { get; set; }

        [Display(Name = "Parent Funeral Home")]
        public string ParentName { get; set; }
        public virtual ICollection<ParentFuneralHome> ParentFuneralHomes { get; set; }

        [Display(Name = "Plant Name")]
        public string PlantName { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }
        public string ContactName { get; set; }
        public virtual ICollection<FuneralHomeContact> Contacts { get; set; }

    }
}
