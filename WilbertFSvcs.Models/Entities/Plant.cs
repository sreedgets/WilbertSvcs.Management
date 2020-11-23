using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WilbertFSvcs.Models.Misc;

namespace WilbertFSvcs.Models.Entities
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string PlantName { get; set; }
        [EmailAddress]
        public string PlantManagerEmail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public List<Phone> PhNumbers { get; set; }
        public Boolean PrintCompletedOrders { get; set; }
        public List<Employee> Employees { get; set; }
        public List<VaultOrder> Orders { get; set; }
    }
}
