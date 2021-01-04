﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class FuneralHome
    {
        public FuneralHome()
        {
            ParentFuneralHomes = new HashSet<ParentFuneralHome>();
            Plants = new HashSet<Plant>();
        }

        public int FuneralHomeId { get; set; }
        public int? ParentFuneralHomeId { get; set; }
        public int? PlantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
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
        public string PhoneType1 { get; set; }
        public string PhoneType2 { get; set; }
        [Display(Name = "Parent Funeral Home?")]
        public bool IsParent { get; set; }

        [Display(Name = "Parent Name")]
        public string ParentName { get; set; }
        public virtual ICollection<ParentFuneralHome> ParentFuneralHomes { get; set; }

        [Display(Name = "Plant Name")]
        public string PlantName { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }

    }
}
