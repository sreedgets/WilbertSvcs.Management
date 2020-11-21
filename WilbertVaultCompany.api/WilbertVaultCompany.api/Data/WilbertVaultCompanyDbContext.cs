using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WilbertVaultCompany.api.Models;

namespace WilbertVaultCompany.api.Data
{
    public class WilbertVaultCompanyDbContext : DbContext
    {
        public WilbertVaultCompanyDbContext (DbContextOptions<WilbertVaultCompanyDbContext> options)
            : base(options)
        {
        }

        public DbSet<WilbertVaultCompany.api.Models.FuneralHome> FuneralHome { get; set; }
    }
}
