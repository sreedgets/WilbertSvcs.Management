using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class FuneralHomeContact
    {
        public int FuneralHomeContactId { get; set; }
        public int FuneralHomeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Spouse { get; set; }
        public bool ShowPrices { get; set; }
        public int ContactRole { get; set; }
        public string Interests { get; set; }
        public byte[] Photo { get; set; }
    }
}
