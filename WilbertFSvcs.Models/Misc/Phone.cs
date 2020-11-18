using System;
using System.Collections.Generic;
using System.Text;
using WilbertFSvcs.Models.Enums;

namespace WilbertFSvcs.Models.Misc
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public int EntityId { get; set; }
        public string Number { get; set; }

        public PhoneType PhoneType { get; set; }
    }
}
