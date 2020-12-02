using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertVaultCompany.api.Models
{
    public class ParentFuneralHome
    {
        public int id { get; set; }
        public string parent_funeralhome_name { get; set; }
        public FuneralHome funral_home { get; set; }
    }
}
