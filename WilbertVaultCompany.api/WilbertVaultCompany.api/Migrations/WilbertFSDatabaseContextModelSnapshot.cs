﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WilbertVaultCompany.api.Models;

namespace WilbertVaultCompany.api.Migrations
{
    [DbContext(typeof(WilbertFSDatabaseContext))]
    partial class WilbertFSDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WilbertVaultCompany.api.Models.AllowedToSelect", b =>
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

                    b.ToTable("AllowedToSelects");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Cemetary", b =>
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

                    b.ToTable("Cemetaries");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Deceased", b =>
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

                    b.Property<int>("Suffix")
                        .HasColumnType("int");

                    b.HasKey("DeceasedId");

                    b.ToTable("Deceaseds");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("AmtPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("AwningSet")
                        .HasColumnType("bit");

                    b.Property<string>("Cemetary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ChairsSet")
                        .HasColumnType("bit");

                    b.Property<int>("DeceasedId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveringPlant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Driver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipInNeedOfRepair")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EquipPolished")
                        .HasColumnType("bit");

                    b.Property<string>("FdarrivalTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FdcommentsAndRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FuneralDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuneralDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuneralHome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GravesideTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MilesTo")
                        .HasColumnType("int");

                    b.Property<bool>("OilTiresChecked")
                        .HasColumnType("bit");

                    b.Property<string>("OrderingPlant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaidTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ReadyOnTime")
                        .HasColumnType("bit");

                    b.Property<string>("ReasonTentNotSet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemarksOrProblems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReturnTimeInMinutes")
                        .HasColumnType("int");

                    b.Property<bool>("ReviewedByOffice")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SetupTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SideWalls")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TentSet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeInPlant")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeLeftPlant")
                        .HasColumnType("datetime2");

                    b.Property<string>("Truck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TruckNum")
                        .HasColumnType("int");

                    b.Property<bool>("UniformClean")
                        .HasColumnType("bit");

                    b.Property<int>("VaultOrderId")
                        .HasColumnType("int");

                    b.HasKey("DeliveryId");

                    b.HasIndex("DeceasedId");

                    b.HasIndex("VaultOrderId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Employee", b =>
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

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHome", b =>
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

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneType1")
                        .HasColumnType("int");

                    b.Property<int>("PhoneType2")
                        .HasColumnType("int");

                    b.Property<int?>("PlantId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("FuneralHomeId");

                    b.HasIndex("PlantId");

                    b.ToTable("FuneralHomes");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHomeContact", b =>
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

                    b.ToTable("FuneralHomeContacts");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Interaction", b =>
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

                    b.ToTable("Interactions");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Phone", b =>
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

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Photo", b =>
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

                    b.Property<string>("TruckId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PhotoId");

                    b.HasIndex("FuneralHomeId");

                    b.HasIndex("TruckId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Plant", b =>
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

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType2")
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

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Truck", b =>
                {
                    b.Property<string>("TruckId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AcquisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DriverEmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("Inactive")
                        .HasColumnType("bit");

                    b.Property<string>("InactiveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LicPlateRenewal")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<string>("RegCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RegFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Tonnage")
                        .HasColumnType("int");

                    b.Property<long>("TruckNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TruckId");

                    b.HasIndex("DriverEmployeeId");

                    b.HasIndex("PlantId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Vault", b =>
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

                    b.ToTable("Vaults");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.VaultOrder", b =>
                {
                    b.Property<int>("VaultOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("AwningOverCasket")
                        .HasColumnType("bit");

                    b.Property<int>("Category")
                        .HasColumnType("int");

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

                    b.Property<string>("Fdrequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FuneralDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuneralDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuneralHome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FuneralTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<bool>("MilitarySetup")
                        .HasColumnType("bit");

                    b.Property<string>("NewFuneralDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewFuneralHome")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("VaultOrderId");

                    b.HasIndex("CemetaryId");

                    b.HasIndex("DeceasedId");

                    b.HasIndex("PlantId");

                    b.HasIndex("VaultId");

                    b.ToTable("VaultOrders");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Delivery", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Deceased", "Deceased")
                        .WithMany("Deliveries")
                        .HasForeignKey("DeceasedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WilbertVaultCompany.api.Models.VaultOrder", "VaultOrder")
                        .WithMany("Deliveries")
                        .HasForeignKey("VaultOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deceased");

                    b.Navigation("VaultOrder");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Employee", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Plant", "Plant")
                        .WithMany("Employees")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHome", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Plant", "Plant")
                        .WithMany("FuneralHomes")
                        .HasForeignKey("PlantId");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHomeContact", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", "FuneralHome")
                        .WithMany("FuneralHomeContacts")
                        .HasForeignKey("FuneralHomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FuneralHome");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Interaction", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", "FuneralHome")
                        .WithMany("Interactions")
                        .HasForeignKey("FuneralHomeId");

                    b.Navigation("FuneralHome");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Phone", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Employee", "Employee")
                        .WithMany("Phones")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHomeContact", "FuneralHomeContact")
                        .WithMany("Phones")
                        .HasForeignKey("FuneralHomeContactId");

                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", "FuneralHome")
                        .WithMany()
                        .HasForeignKey("FuneralHomeId");

                    b.HasOne("WilbertVaultCompany.api.Models.Plant", "Plant")
                        .WithMany()
                        .HasForeignKey("PlantId");

                    b.Navigation("Employee");

                    b.Navigation("FuneralHome");

                    b.Navigation("FuneralHomeContact");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Photo", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", "FuneralHome")
                        .WithMany("Photos")
                        .HasForeignKey("FuneralHomeId");

                    b.HasOne("WilbertVaultCompany.api.Models.Truck", "Truck")
                        .WithMany("Photos")
                        .HasForeignKey("TruckId");

                    b.Navigation("FuneralHome");

                    b.Navigation("Truck");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Truck", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Employee", "DriverEmployee")
                        .WithMany("Trucks")
                        .HasForeignKey("DriverEmployeeId");

                    b.HasOne("WilbertVaultCompany.api.Models.Plant", "Plant")
                        .WithMany("Trucks")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DriverEmployee");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Vault", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.AllowedToSelect", "AllowedToSelect")
                        .WithMany("Vaults")
                        .HasForeignKey("AllowedToSelectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllowedToSelect");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.VaultOrder", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Cemetary", "Cemetary")
                        .WithMany("VaultOrders")
                        .HasForeignKey("CemetaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WilbertVaultCompany.api.Models.Deceased", "Deceased")
                        .WithMany("VaultOrders")
                        .HasForeignKey("DeceasedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WilbertVaultCompany.api.Models.Plant", "Plant")
                        .WithMany("VaultOrders")
                        .HasForeignKey("PlantId");

                    b.HasOne("WilbertVaultCompany.api.Models.Vault", "Vault")
                        .WithMany("VaultOrders")
                        .HasForeignKey("VaultId");

                    b.Navigation("Cemetary");

                    b.Navigation("Deceased");

                    b.Navigation("Plant");

                    b.Navigation("Vault");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.AllowedToSelect", b =>
                {
                    b.Navigation("Vaults");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Cemetary", b =>
                {
                    b.Navigation("VaultOrders");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Deceased", b =>
                {
                    b.Navigation("Deliveries");

                    b.Navigation("VaultOrders");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Employee", b =>
                {
                    b.Navigation("Phones");

                    b.Navigation("Trucks");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHome", b =>
                {
                    b.Navigation("FuneralHomeContacts");

                    b.Navigation("Interactions");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHomeContact", b =>
                {
                    b.Navigation("Phones");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Plant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("FuneralHomes");

                    b.Navigation("Trucks");

                    b.Navigation("VaultOrders");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Truck", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Vault", b =>
                {
                    b.Navigation("VaultOrders");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.VaultOrder", b =>
                {
                    b.Navigation("Deliveries");
                });
#pragma warning restore 612, 618
        }
    }
}
