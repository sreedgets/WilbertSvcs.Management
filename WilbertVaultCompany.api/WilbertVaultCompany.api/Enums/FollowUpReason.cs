using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertVaultCompany.api.Enums
{
    public enum FollowUpReason
    {
        [Display(Name = "- Select -")]
        Choose,

        [Display(Name = "Get Orders")]
        GetOrders,

        Schmooze,
        Courtesy
    }
}
