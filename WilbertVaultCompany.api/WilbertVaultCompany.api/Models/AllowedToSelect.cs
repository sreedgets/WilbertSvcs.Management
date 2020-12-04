using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class AllowedToSelect
    {
        public int AllowedToSelectId { get; set; }
        public int VaultId { get; set; }
        public bool FullAccess { get; set; }
        public bool FuneralHomes { get; set; }
        public bool Drivers { get; set; }
        public bool PlantManagers { get; set; }
        public bool OfficeStaff { get; set; }
    }
}
