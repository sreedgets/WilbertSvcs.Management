using System;
using System.Collections.Generic;
using System.Text;

namespace WilbertFSvcs.Models.Misc
{
    public class AllowedToSelect
    {
        public int AllowedToSelectId { get; set; }
        public int VaultId { get; set; }
        public Boolean FullAccess { get; set; }
        public Boolean FuneralHomes { get; set; }
        public Boolean Drivers { get; set; }
        public Boolean PlantManagers { get; set; }
        public Boolean OfficeStaff { get; set; }
    }
}
