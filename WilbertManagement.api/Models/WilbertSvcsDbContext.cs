using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilbertManagement.api.Models
{
    public class WilbertSvcsDbContext : DbContext
    {
        public WilbertSvcsDbContext(DbContextOptions<WilbertSvcsDbContext> options)
         : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WilbertSvcsDbContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
