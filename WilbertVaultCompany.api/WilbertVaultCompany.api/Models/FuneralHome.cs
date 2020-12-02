using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class FuneralHome
    {
        public FuneralHome()
        {
            FuneralHomeContacts = new HashSet<FuneralHomeContact>();
            Interactions = new HashSet<Interaction>();
            //Phones = new HashSet<Phone>();
            Photos = new HashSet<Photo>();
        }

        public int FuneralHomeId { get; set; }

        [Display(Name = "Parent Fueneral Home")]
        public int? ParentFuneralHomeId { get; set; }
      
        public List<ParentFuneralHome> Parent_Funeral_Homes { get; set; }
        public string Name { get; set; }
        public int? PlantId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public virtual Plant Plant { get; set; }
        public virtual ICollection<FuneralHomeContact> FuneralHomeContacts { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set; }
        //public virtual ICollection<Phone> Phones { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone1 { get; set; }
        public string PhoneType1 { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone2 { get; set; }
        public string PhoneType2 { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
