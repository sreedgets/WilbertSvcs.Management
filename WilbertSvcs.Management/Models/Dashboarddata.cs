using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertSvcs.Management.Models
{
    public  class Dashboarddata
    {
        public  UserManager<WilbertAppUser> userManager { get; set; }

        public  WilbertAppUser wilbertAppUser { get; set; }
    }
}
