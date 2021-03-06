﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class FuneralHomeContact
    {
        public int FuneralHomeContactId { get; set; }
        public int FuneralHomeId { get; set; }

        public string fhName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }

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
        public string Email { get; set; }
        public string Spouse { get; set; }
        public bool ShowPrices { get; set; }

        [Display(Name = "Contact Role")]
        public string ContactRole { get; set; }
        public string Interests { get; set; }
        public byte[] Photo { get; set; }
        public Tab ActiveTab { get; set; }

        public enum Tab
        {
            Details,
            Preferences
        }

    }
}
