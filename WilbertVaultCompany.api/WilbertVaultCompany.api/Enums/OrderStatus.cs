using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WilbertVaultCompany.api.Enums
{
    public enum OrderStatus
    {
        [Display(Name = "-Select-")]
        Choose,
        Entered,
        Confirmed,
        Routed,
        Delivered
    }
}
