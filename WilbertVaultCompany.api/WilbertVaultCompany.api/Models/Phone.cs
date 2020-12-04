using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Phone
    {
        public int PhoneId { get; set; }
        public int EntityId { get; set; }
        public string Number { get; set; }
        public int PhoneType { get; set; }
        public int? EmployeeId { get; set; }
        public int? FuneralHomeContactId { get; set; }
        public int? FuneralHomeId { get; set; }
        public int? PlantId { get; set; }
    }
}
