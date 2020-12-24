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

        public virtual DbSet<FuneralHome> FuneralHomes { get; set; }
        public virtual DbSet<FuneralHomeContact> FuneralHomeContacts { get; set; }
        public virtual DbSet<Interaction> Interactions { get; set; }
        public virtual DbSet<ParentFuneralHome> ParentFuneralHomes { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=173.248.151.15,1533;database=wilbertdb;User ID=sa;Password=V3@nd#0r$1Afw;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ParentFuneralHome>(entity =>
            {
                entity.HasIndex(e => e.FunralHomeFuneralHomeId, "IX_ParentFuneralHomes_FunralHomeFuneralHomeId");

                entity.HasOne(d => d.FunralHomeFuneralHome)
                    .WithMany(p => p.ParentFuneralHomes)
                    .HasForeignKey(d => d.FunralHomeFuneralHomeId);
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.Property(e => e.PlantId).ValueGeneratedNever();

                entity.HasOne(d => d.PlantNavigation)
                    .WithOne(p => p.Plant)
                    .HasForeignKey<Plant>(d => d.PlantId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
