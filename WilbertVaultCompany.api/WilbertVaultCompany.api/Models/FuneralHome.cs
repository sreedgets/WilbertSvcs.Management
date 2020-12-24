using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class FuneralHome
    {
        public FuneralHome()
        {
            ParentFuneralHomes = new HashSet<ParentFuneralHome>();
        }

        public int FuneralHomeId { get; set; }

        [Display(Name = "Parent Home")]
        public int? ParentFuneralHomeId { get; set; }

        [Display(Name = "Funeral Home")]
        public string Name { get; set; }
        public virtual Plant Plant { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PhoneType1 { get; set; }
        public string PhoneType2 { get; set; }

        [Display(Name = "Is Parent Home?")]
        public bool IsParent { get; set; }
        public string ParentName { get; set; }

        public virtual ICollection<ParentFuneralHome> ParentFuneralHomes { get; set; }
    }
}
