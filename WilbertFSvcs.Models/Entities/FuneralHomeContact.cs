using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WilbertFSvcs.Models.Enums;
using WilbertFSvcs.Models.Misc;

namespace WilbertFSvcs.Model.Entities
{
    public class FuneralHomeContact
    {
        [Key]
        public int FuneralHomeContactId { get; set; }
        public int FuneralHomeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName{ get; set; }
        public string Spouse { get; set; }
        public Boolean ShowPrices { get; set; }
        public FuneralHomeRole ContactRole { get; set; }
        public string Interests { get; set; }
        public List<Phone> PhNumbers { get; set; }
        public Byte[] Photo { get; set; }
    }
}
