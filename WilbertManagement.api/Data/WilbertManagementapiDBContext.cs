using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WilbertFSvcs.Model.Entities;

namespace WilbertManagement.api.Data
{
    public class WilbertManagementapiDBContext : DbContext
    {
        public WilbertManagementapiDBContext()
        {

        }
        public WilbertManagementapiDBContext (DbContextOptions<WilbertManagementapiDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WilbertManagementapiDBContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


    }
}
