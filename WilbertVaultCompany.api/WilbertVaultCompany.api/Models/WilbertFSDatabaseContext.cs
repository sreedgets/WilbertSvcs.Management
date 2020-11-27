using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class WilbertFSDatabaseContext : DbContext
    {
        public WilbertFSDatabaseContext()
        {
        }

        public WilbertFSDatabaseContext(DbContextOptions<WilbertFSDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllowedToSelect> AllowedToSelects { get; set; }
        public virtual DbSet<Cemetary> Cemetaries { get; set; }
        public virtual DbSet<Deceased> Deceaseds { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FuneralHome> FuneralHomes { get; set; }
        public virtual DbSet<FuneralHomeContact> FuneralHomeContacts { get; set; }
        public virtual DbSet<Interaction> Interactions { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<Vault> Vaults { get; set; }
        public virtual DbSet<VaultOrder> VaultOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=173.248.151.15,1533;database=wilbertdb;User ID=sa;Password=V3@nd#0r$1Afw;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }


    }

}
