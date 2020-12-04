using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Vault
    {
        public int VaultId { get; set; }
        public string Description { get; set; }
        public bool Ovation { get; set; }
        public bool Decoration { get; set; }
        public bool Legacy { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string VaultCode { get; set; }
        public int AllowedToSelectId { get; set; }
        public bool UpChargeForLegacy { get; set; }
        public decimal UpChargeAmount { get; set; }
        public int VaultCategory { get; set; }
        public int Color { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Comments { get; set; }
        public byte[] PhotoImage { get; set; }
    }
}
