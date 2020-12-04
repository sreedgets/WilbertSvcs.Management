using System;
using System.Collections.Generic;

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
        public int? ParentFuneralHomeId { get; set; }
        public string Name { get; set; }
        public int? PlantId { get; set; }
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
        public bool IsParent { get; set; }
        public string ParentName { get; set; }

        public virtual ICollection<ParentFuneralHome> ParentFuneralHomes { get; set; }
    }
}
