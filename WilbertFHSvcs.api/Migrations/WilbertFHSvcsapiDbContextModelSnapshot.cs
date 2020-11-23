﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WilbertFHSvcs.api.Data;

namespace WilbertFHSvcs.api.Migrations
{
    [DbContext(typeof(WilbertFHSvcsapiDbContext))]
    partial class WilbertFHSvcsapiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WilbertFSvcs.Model.Entities.FuneralHomeContact", b =>
                {
                    b.Property<int>("FuneralHomeContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ContactRole")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuneralHomeId")
                        .HasColumnType("int");

                    b.Property<string>("Interests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("ShowPrices")
                        .HasColumnType("bit");

                    b.Property<string>("Spouse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuneralHomeContactId");

                    b.HasIndex("FuneralHomeId");

                    b.ToTable("FuneralHomeContact");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Cemetary", b =>
                {
                    b.Property<int>("CemetaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Directions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Lattitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<byte[]>("Map")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UseCoordinates")
                        .HasColumnType("bit");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CemetaryId");

                    b.ToTable("Cemetary");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Deceased", b =>
                {
                    b.Property<int>("DeceasedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("suffix")
                        .HasColumnType("int");

                    b.HasKey("DeceasedId");

                    b.ToTable("Deceased");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CanDoFollowUps")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Title")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("PlantId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.FuneralHome", b =>
                {
                    b.Property<int>("FuneralHomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentFuneralHomeId")
                        .HasColumnType("int");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("FuneralHomeId");

                    b.HasIndex("PlantId");

                    b.ToTable("FuneralHome");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantManagerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrintCompletedOrders")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("PlantId");

                    b.ToTable("Plant");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Vault", b =>
                {
                    b.Property<int>("VaultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AllowedToSelectId")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("Color1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Decoration")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Legacy")
                        .HasColumnType("bit");

                    b.Property<bool>("Ovation")
                        .HasColumnType("bit");

                    b.Property<byte[]>("PhotoImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UpChargeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("UpChargeForLegacy")
                        .HasColumnType("bit");

                    b.Property<int>("VaultCategory")
                        .HasColumnType("int");

                    b.Property<string>("VaultCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaultId");

                    b.HasIndex("AllowedToSelectId");

                    b.ToTable("Vault");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.VaultOrder", b =>
                {
                    b.Property<int>("VaultOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("AwningOverCasket")
                        .HasColumnType("bit");

                    b.Property<int>("CemetaryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CemetaryTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeceasedId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveringPlant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExtraChairs")
                        .HasColumnType("int");

                    b.Property<string>("FDRequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FuneralDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FuneralTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<bool>("MilitarySetup")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderingPlant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantId")
                        .HasColumnType("int");

                    b.Property<bool>("RegisterStand")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TentWith6Chairs")
                        .HasColumnType("bit");

                    b.Property<int?>("VaultId")
                        .HasColumnType("int");

                    b.Property<int>("VenetianCarapace")
                        .HasColumnType("int");

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.Property<string>("funeralDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("funeralHome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("newFuneralDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("newFuneralHome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaultOrderId");

                    b.HasIndex("CemetaryId");

                    b.HasIndex("DeceasedId");

                    b.HasIndex("PlantId");

                    b.HasIndex("VaultId");

                    b.ToTable("VaultOrder");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Misc.AllowedToSelect", b =>
                {
                    b.Property<int>("AllowedToSelectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Drivers")
                        .HasColumnType("bit");

                    b.Property<bool>("FullAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("FuneralHomes")
                        .HasColumnType("bit");

                    b.Property<bool>("OfficeStaff")
                        .HasColumnType("bit");

                    b.Property<bool>("PlantManagers")
                        .HasColumnType("bit");

                    b.Property<int>("VaultId")
                        .HasColumnType("int");

                    b.HasKey("AllowedToSelectId");

                    b.ToTable("AllowedToSelect");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Misc.Interaction", b =>
                {
                    b.Property<int>("InteractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FollowUpDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuneralHomeId")
                        .HasColumnType("int");

                    b.Property<int>("Nature")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outcome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reason")
                        .HasColumnType("int");

                    b.HasKey("InteractionId");

                    b.HasIndex("FuneralHomeId");

                    b.ToTable("Interaction");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Misc.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EntityId")
                        .HasColumnType("int");

                    b.Property<int?>("FuneralHomeContactId")
                        .HasColumnType("int");

                    b.Property<int?>("FuneralHomeId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneType")
                        .HasColumnType("int");

                    b.Property<int?>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("PhoneId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("FuneralHomeContactId");

                    b.HasIndex("FuneralHomeId");

                    b.HasIndex("PlantId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Misc.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("FuneralHomeId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PhotoImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoId");

                    b.HasIndex("FuneralHomeId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("WilbertFSvcs.Model.Entities.FuneralHomeContact", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Entities.FuneralHome", null)
                        .WithMany("Contacts")
                        .HasForeignKey("FuneralHomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Employee", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Entities.Plant", "EmployeePlant")
                        .WithMany("Employees")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeePlant");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.FuneralHome", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Entities.Plant", "plant")
                        .WithMany()
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("plant");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Vault", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Misc.AllowedToSelect", "VaultSelections")
                        .WithMany()
                        .HasForeignKey("AllowedToSelectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaultSelections");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.VaultOrder", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Entities.Cemetary", "cemetary")
                        .WithMany()
                        .HasForeignKey("CemetaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WilbertFSvcs.Models.Entities.Deceased", "deceased")
                        .WithMany()
                        .HasForeignKey("DeceasedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WilbertFSvcs.Models.Entities.Plant", null)
                        .WithMany("Orders")
                        .HasForeignKey("PlantId");

                    b.HasOne("WilbertFSvcs.Models.Entities.Vault", "vault")
                        .WithMany()
                        .HasForeignKey("VaultId");

                    b.Navigation("cemetary");

                    b.Navigation("deceased");

                    b.Navigation("vault");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Misc.Interaction", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Entities.FuneralHome", null)
                        .WithMany("Interactions")
                        .HasForeignKey("FuneralHomeId");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Misc.Phone", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Entities.Employee", null)
                        .WithMany("PhNumbers")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("WilbertFSvcs.Model.Entities.FuneralHomeContact", null)
                        .WithMany("PhNumbers")
                        .HasForeignKey("FuneralHomeContactId");

                    b.HasOne("WilbertFSvcs.Models.Entities.FuneralHome", null)
                        .WithMany("PhNumbers")
                        .HasForeignKey("FuneralHomeId");

                    b.HasOne("WilbertFSvcs.Models.Entities.Plant", null)
                        .WithMany("PhNumbers")
                        .HasForeignKey("PlantId");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Misc.Photo", b =>
                {
                    b.HasOne("WilbertFSvcs.Models.Entities.FuneralHome", null)
                        .WithMany("Photos")
                        .HasForeignKey("FuneralHomeId");
                });

            modelBuilder.Entity("WilbertFSvcs.Model.Entities.FuneralHomeContact", b =>
                {
                    b.Navigation("PhNumbers");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Employee", b =>
                {
                    b.Navigation("PhNumbers");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.FuneralHome", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Interactions");

                    b.Navigation("PhNumbers");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("WilbertFSvcs.Models.Entities.Plant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Orders");

                    b.Navigation("PhNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
