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
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WilbertFSDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllowedToSelect>(entity =>
            {
                entity.ToTable("AllowedToSelect");
            });

            modelBuilder.Entity<Cemetary>(entity =>
            {
                entity.ToTable("Cemetary");
            });

            modelBuilder.Entity<Deceased>(entity =>
            {
                entity.ToTable("Deceased");

                entity.Property(e => e.Suffix).HasColumnName("suffix");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.HasIndex(e => e.DeceasedId, "IX_Delivery_DeceasedId");

                entity.HasIndex(e => e.VaultOrderId, "IX_Delivery_VaultOrderId");

                entity.Property(e => e.AmtPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FdarrivalTime).HasColumnName("FDArrivalTime");

                entity.Property(e => e.FdcommentsAndRemarks).HasColumnName("FDCommentsAndRemarks");

                entity.Property(e => e.TimeInPlant).HasColumnName("TimeIn_Plant");

                entity.HasOne(d => d.Deceased)
                    .WithMany(p => p.Deliveries)
                    .HasForeignKey(d => d.DeceasedId);

                entity.HasOne(d => d.VaultOrder)
                    .WithMany(p => p.Deliveries)
                    .HasForeignKey(d => d.VaultOrderId);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.PlantId, "IX_Employee_PlantId");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PlantId);
            });

            modelBuilder.Entity<FuneralHome>(entity =>
            {
                entity.ToTable("FuneralHome");

                entity.HasIndex(e => e.PlantId, "IX_FuneralHome_PlantId");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.FuneralHomes)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<FuneralHomeContact>(entity =>
            {
                entity.ToTable("FuneralHomeContact");

                entity.HasIndex(e => e.FuneralHomeId, "IX_FuneralHomeContact_FuneralHomeId");

                entity.HasOne(d => d.FuneralHome)
                    .WithMany(p => p.FuneralHomeContacts)
                    .HasForeignKey(d => d.FuneralHomeId);
            });

            modelBuilder.Entity<Interaction>(entity =>
            {
                entity.ToTable("Interaction");

                entity.HasIndex(e => e.FuneralHomeId, "IX_Interaction_FuneralHomeId");

                entity.HasOne(d => d.FuneralHome)
                    .WithMany(p => p.Interactions)
                    .HasForeignKey(d => d.FuneralHomeId);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.ToTable("Phone");

                entity.HasIndex(e => e.EmployeeId, "IX_Phone_EmployeeId");

                entity.HasIndex(e => e.FuneralHomeContactId, "IX_Phone_FuneralHomeContactId");

                entity.HasIndex(e => e.FuneralHomeId, "IX_Phone_FuneralHomeId");

                entity.HasIndex(e => e.PlantId, "IX_Phone_PlantId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.FuneralHomeContact)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.FuneralHomeContactId);

                entity.HasOne(d => d.FuneralHome)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.FuneralHomeId);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.PlantId);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("Photo");

                entity.HasIndex(e => e.FuneralHomeId, "IX_Photo_FuneralHomeId");

                entity.HasIndex(e => e.TruckId, "IX_Photo_TruckId");

                entity.HasOne(d => d.FuneralHome)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.FuneralHomeId);

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.TruckId);
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.ToTable("Plant");
            });

            modelBuilder.Entity<Truck>(entity =>
            {
                entity.ToTable("Truck");

                entity.HasIndex(e => e.DriverEmployeeId, "IX_Truck_DriverEmployeeId");

                entity.HasIndex(e => e.PlantId, "IX_Truck_PlantId");

                entity.Property(e => e.RegFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vin).HasColumnName("VIN");

                entity.HasOne(d => d.DriverEmployee)
                    .WithMany(p => p.Trucks)
                    .HasForeignKey(d => d.DriverEmployeeId);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Trucks)
                    .HasForeignKey(d => d.PlantId);
            });

            modelBuilder.Entity<Vault>(entity =>
            {
                entity.ToTable("Vault");

                entity.HasIndex(e => e.AllowedToSelectId, "IX_Vault_AllowedToSelectId");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpChargeAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AllowedToSelect)
                    .WithMany(p => p.Vaults)
                    .HasForeignKey(d => d.AllowedToSelectId);
            });

            modelBuilder.Entity<VaultOrder>(entity =>
            {
                entity.ToTable("VaultOrder");

                entity.HasIndex(e => e.CemetaryId, "IX_VaultOrder_CemetaryId");

                entity.HasIndex(e => e.DeceasedId, "IX_VaultOrder_DeceasedId");

                entity.HasIndex(e => e.PlantId, "IX_VaultOrder_PlantId");

                entity.HasIndex(e => e.VaultId, "IX_VaultOrder_VaultId");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Fdrequest).HasColumnName("FDRequest");

                entity.Property(e => e.FuneralDirector).HasColumnName("funeralDirector");

                entity.Property(e => e.FuneralHome).HasColumnName("funeralHome");

                entity.Property(e => e.NewFuneralDirector).HasColumnName("newFuneralDirector");

                entity.Property(e => e.NewFuneralHome).HasColumnName("newFuneralHome");

                entity.HasOne(d => d.Cemetary)
                    .WithMany(p => p.VaultOrders)
                    .HasForeignKey(d => d.CemetaryId);

                entity.HasOne(d => d.Deceased)
                    .WithMany(p => p.VaultOrders)
                    .HasForeignKey(d => d.DeceasedId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.VaultOrders)
                    .HasForeignKey(d => d.PlantId);

                entity.HasOne(d => d.Vault)
                    .WithMany(p => p.VaultOrders)
                    .HasForeignKey(d => d.VaultId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
