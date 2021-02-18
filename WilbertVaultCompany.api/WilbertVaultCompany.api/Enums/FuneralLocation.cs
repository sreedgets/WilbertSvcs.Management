using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WilbertVaultCompany.api.Enums
{
    public enum FuneralLocation
    {
        Graveside,
        [Display(Name = "Funersl Home")]
        FuneralHome,
        Church,
        [Display(Name ="Service,  Lunch Before Burial")]
        Service_LunchBeforeBurial,
        [Display(Name ="Burial Before Service")]
        BurialBeforeService
    }
}
