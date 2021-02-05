using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertProductCompany.api.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public bool Ovation { get; set; }
        public bool Decoration { get; set; }
        public bool Legacy { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public int AllowedToSelectId { get; set; }
        public bool UpChargeForLegacy { get; set; }
        public decimal UpChargeAmount { get; set; }
        public int ProductCategory { get; set; }
        public int Color { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Comments { get; set; }
        public byte[] PhotoImage { get; set; }
    }
}
