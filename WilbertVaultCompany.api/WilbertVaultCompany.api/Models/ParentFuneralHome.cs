using System;
using System.Collections.Generic;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class ParentFuneralHome
    {
        public int Id { get; set; }
        public string ParentFuneralhomeName { get; set; }
        public int? FunralHomeFuneralHomeId { get; set; }

        public virtual FuneralHome FunralHomeFuneralHome { get; set; }
    }
}
