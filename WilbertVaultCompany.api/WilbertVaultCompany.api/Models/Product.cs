using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public bool Ovation { get; set; }
        public bool Decoration { get; set; }
        public bool Legacy { get; set; }
        [Display(Name = "Venetian Carapace")]
        public string VenetianCarapace { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        
        [Display(Name = "Product Code")] 
        public string ProductCode { get; set; }

        [Display(Name = "Allowed to Select")]
        public int AllowedToSelectId { get; set; }

        [Display(Name = "Up Charge For Legacy")]
        public bool UpChargeForLegacy { get; set; }

        [Display(Name = "Amount")]
        public decimal UpChargeAmount { get; set; }
        
        [Display(Name = "Category")]
        public string ProductCategory { get; set; }
        public string Color { get; set; }

        [Display(Name = " Color 1")]
        public string Color1 { get; set; }

        [Display(Name = "Color 2")]
        public string Color2 { get; set; }
        public string Comments { get; set; }

        [Display(Name = "Photo Image")]
        public byte[] PhotoImage { get; set; }

    }
}
