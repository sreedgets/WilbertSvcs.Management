using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertFSvcs.Models.Misc
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public byte[] PhotoImage { get; set; }
    }
}
