using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Deceased
    {
        public Deceased()
        {
            Deliveries = new HashSet<Delivery>();
            VaultOrders = new HashSet<VaultOrder>();
        }

        public int DeceasedId { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Suffix { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime DiedDate { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<VaultOrder> VaultOrders { get; set; }
    }
}
