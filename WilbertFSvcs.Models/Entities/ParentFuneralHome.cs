
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WilbertFSvcs.Models.Entities;
using WilbertFSvcs.Models.Misc;


namespace WilbertFSvcs.Models.Entities
{
    public class ParentFuneralHome
    {

        public int ParentFuneralHomeId { get; set; }
        public string Name { get; set; }
       
        public List<FuneralHomeContact> Contacts { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public List<Phone> PhNumbers { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public List<Interaction> Interactions { get; set; }
        public List<Photo> Photos { get; set; }

    }
}
