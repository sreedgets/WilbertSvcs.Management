using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WilbertVaultCompany.api.Models
{
    public partial class wilbertdbContext : DbContext
    {
        public wilbertdbContext()
        {
        }

        public wilbertdbContext(DbContextOptions<wilbertdbContext> options)
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
        public virtual DbSet<ParentFuneralHome> ParentFuneralHomes { get; set; }
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
                //optionsBuilder.UseSqlServer("Server=173.248.151.15,1533;database=wilbertdb;User ID=sa;Password=V3@nd#0r$1Afw;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=wilbertdb;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllowedToSelect>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Cemetary>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Deceased>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AmtPaid).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<FuneralHome>(entity =>
            {
                entity.Property(e => e.IsParent)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<FuneralHomeContact>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Interaction>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ParentFuneralHome>(entity =>
            {
                entity.ToTable("ParentFuneralHome");

                entity.HasIndex(e => e.FunralHomeFuneralHomeId, "IX_ParentFuneralHome_funral_homeFuneralHomeId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FunralHomeFuneralHomeId).HasColumnName("funral_homeFuneralHomeId");

                entity.Property(e => e.ParentFuneralhomeName).HasColumnName("parent_funeralhome_name");

                entity.HasOne(d => d.FunralHomeFuneralHome)
                    .WithMany(p => p.ParentFuneralHomes)
                    .HasForeignKey(d => d.FunralHomeFuneralHomeId);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TruckId).HasMaxLength(450);
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Truck>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RegFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TruckId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Vault>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpChargeAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VaultOrder>(entity =>
            {
                entity.HasNoKey();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
