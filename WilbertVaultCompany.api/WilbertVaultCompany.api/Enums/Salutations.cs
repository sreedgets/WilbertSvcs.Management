using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertVaultCompany.api.Enums
{
    public enum Salutations
    {
        [Display(Name = "-Select-")]
        Choose,
        [Display(Name = "Dr.")]
        Dr,
        Father,
        Honorary,
        Reverend,
        Deacon
    }
}
