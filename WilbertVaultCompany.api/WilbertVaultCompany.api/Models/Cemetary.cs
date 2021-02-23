using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class Cemetary
    {
        public Cemetary()
        {
            Plants = new HashSet<Plant>();
        }
        public int CemetaryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Display(Name = "Address sLine 2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone1 { get; set; }
        public string PhoneType1 { get; set; }
        public string Directions { get; set; }
        public float Lattitude { get; set; }
        public float Longitude { get; set; }
        public byte[] Map { get; set; }
        public bool UseCoordinates { get; set; }

        /**********************************************/

        public int PlantId { get; set; }

        [Display(Name = "Serving Plant")]
        public string PlantName { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }

    }
}
