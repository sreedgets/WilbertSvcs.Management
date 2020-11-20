using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertSvcs.Management.Models
{
    // Note: Employee and FuneralHomeContact
    public class WilbertAppUser : IdentityUser
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }
    }
}
