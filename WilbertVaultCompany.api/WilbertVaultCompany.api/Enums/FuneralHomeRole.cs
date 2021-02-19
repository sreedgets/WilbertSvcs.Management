using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WilbertVaultCompany.api.Enums
{
    public enum FuneralHomeRole
    {
        [Display(Name ="- Select -")]                   // 0
        Choose,
        
        [Display(Name = "Owner & Funeral Director")]    // 1
        Owner_FuneralDirector,
        
        [Display(Name = "Funeral Director")]            // 2
        FuneralDirector,
        
        [Display(Name = "Owner")]                       // 3
        Owner,
        
        [Display(Name = "Admin Staff")]                 // 4
        OfficeAdmin
    }
}
