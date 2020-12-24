using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Plant
    {
        [ForeignKey("FuneralHome")]
        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public string PlantManagerEmail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public virtual FuneralHome FuneralHome { get; set; }
        public string County { get; set; }
        public bool PrintCompletedOrders { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PhoneType1 { get; set; }
        public string PhoneType2 { get; set; }
    }
}
