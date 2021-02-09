using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WilbertVaultCompany.api.Enums
{
    public enum PlantRole
    {
        [Display(Name = "- Select -")]
        Choose,
        [Display(Name = "Franchise Owner")]
        FranchiseOwner,
        [Display(Name = "Franchise Manager")]
        FranchiseManager,
        Driver,
        Sales,
        Admin
    }
}
