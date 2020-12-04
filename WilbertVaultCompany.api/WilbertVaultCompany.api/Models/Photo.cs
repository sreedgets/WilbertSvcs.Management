using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public byte[] PhotoImage { get; set; }
        public int? FuneralHomeId { get; set; }
        public string TruckId { get; set; }
    }
}
