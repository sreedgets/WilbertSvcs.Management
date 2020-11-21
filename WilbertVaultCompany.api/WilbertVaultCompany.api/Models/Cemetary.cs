using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Cemetary
    {
        public Cemetary()
        {
            VaultOrders = new HashSet<VaultOrder>();
        }

        public int CemetaryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public string Directions { get; set; }
        public float Lattitude { get; set; }
        public float Longitude { get; set; }
        public byte[] Map { get; set; }
        public bool UseCoordinates { get; set; }

        public virtual ICollection<VaultOrder> VaultOrders { get; set; }
    }
}
