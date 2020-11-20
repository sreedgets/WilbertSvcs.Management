using Microsoft.EntityFrameworkCore;

namespace WilbertFSvcs.api.Data
{
    public class WilbertDbContext : DbContext
    {
        public WilbertDbContext()
        {

        }

        public WilbertDbContext (DbContextOptions<WilbertDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WilbertFSDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<WilbertFSvcs.Models.Entities.FuneralHome> FuneralHome { get; set; }

        public DbSet<WilbertFSvcs.Models.Entities.FuneralHomeContact> FuneralHomeContact { get; set; }

        public DbSet<WilbertFSvcs.Models.Misc.Interaction> Interaction { get; set; }

        public DbSet<WilbertFSvcs.Models.Misc.Photo> Photo { get; set; }

        public DbSet<WilbertFSvcs.Models.Entities.Plant> Plant { get; set; }

        public DbSet<WilbertFSvcs.Models.Entities.Employee> Employee { get; set; }

        public DbSet<WilbertFSvcs.Models.Entities.Truck> Truck { get; set; }

      
        public DbSet<WilbertFSvcs.Models.Entities.Vault> Vault { get; set; }

        public DbSet<WilbertFSvcs.Models.Entities.Delivery> Delivery { get; set; }

        public DbSet<WilbertFSvcs.Models.Entities.VaultOrder> VaultOrder { get; set; }
        
    }
}
