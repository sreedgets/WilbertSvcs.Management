using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WilbertSvcs.Management.Models;

namespace WilbertSvcs.Management.Models
{
    public class AppIdentityDbContext : IdentityDbContext<WilbertAppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) 
            : base(options)
        { 
        }
        
    }
}
