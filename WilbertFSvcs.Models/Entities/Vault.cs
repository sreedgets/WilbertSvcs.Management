using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;
using WilbertFSvcs.Models.Enums;
using WilbertFSvcs.Models.Misc;

namespace WilbertFSvcs.Models.Entities
{
    public class Vault
    {
        public int VaultId { get; set; }
        public string Description { get; set; }
        public Boolean Ovation { get; set; }
        public Boolean Decoration { get; set; }
        public Boolean Legacy { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string VaultCode { get; set; }
        public int AllowedToSelectId { get; set; }
        
        [ForeignKey("AllowedToSelectId")]
        public AllowedToSelect VaultSelections { get; set; }
        public Boolean UpChargeForLegacy { get; set; }
        public decimal  UpChargeAmount { get; set; }
        public Category VaultCategory { get; set; }
        public VaultColor Color { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Comments { get; set; }
        public byte[] PhotoImage  { get; set; }
    }
}

