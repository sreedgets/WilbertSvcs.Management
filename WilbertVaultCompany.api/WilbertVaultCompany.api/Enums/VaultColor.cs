using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WilbertVaultCompany.api.Enums
{
    public enum  VaultColor
    {
        [Display(Name = "Not Chosen")]
        Choose,
        BlackGold,
        BlueSilver,
        CreamBronze,
        Custom,
        WhiteGold,
        WhiteSilver
    }
}
