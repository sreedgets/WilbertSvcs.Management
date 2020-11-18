using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertSvcs.Management.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<WilbertAppUser> Members { get; set; }
        public IEnumerable<WilbertAppUser> NonMembers { get; set; }
    }
}
