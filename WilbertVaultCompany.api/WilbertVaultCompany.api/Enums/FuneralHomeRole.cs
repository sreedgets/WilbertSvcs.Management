using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WilbertVaultCompany.api.Enums
{
    public enum FuneralHomeRole
    {
        [Display(Name ="- Select -")]
        Choose,
        
        [Display(Name = "Owner & Funeral Director")]
        Owner_FuneralDirector,
        
        [Display(Name = "Director")]
        FuneralDirector,
        
        [Display(Name = "Owner")]
        Owner,
        
        [Display(Name = "Admin Staff")]
        OfficeAdmin
    }
}
