using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WilbertFSvcs.Models.Entities;

namespace WilbertFHSvcs.api.Data
{
    public class WilbertFHSvcsapiDbContext : DbContext
    {

        public WilbertFHSvcsapiDbContext()
        {

        }
        public WilbertFHSvcsapiDbContext (DbContextOptions<WilbertFHSvcsapiDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WilbertFHSvcsapiDbContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<WilbertFSvcs.Models.Entities.FuneralHome> FuneralHome { get; set; }
    }
}
