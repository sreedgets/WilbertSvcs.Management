﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WilbertVaultCompany.api.Models;

namespace WilbertVaultCompany.api.Migrations
{
    [DbContext(typeof(wilbertdbContext))]
    [Migration("20210226142918_addProductsOnVaultOrderTable")]
    partial class addProductsOnVaultOrderTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WilbertVaultCompany.api.Models.ActiveVm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ActiveVm");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Cemetary", b =>
                {
                    b.Property<int>("CemetaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UseCoordinates")
                        .HasColumnType("bit");

                    b.Property<int?>("VaultOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CemetaryId");

                    b.HasIndex("VaultOrderId");

                    b.ToTable("Cemetary");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.CompletedVm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InteractionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InteractionId");

                    b.ToTable("CompletedVm");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Deceased", b =>
                {
                    b.Property<int>("DeceasedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeceasedId");

                    b.ToTable("Deceased");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<int>("SelectedAnswer")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("PlantId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHome", b =>
                {
                    b.Property<int>("FuneralHomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FuneralHomeContactId")
                        .HasColumnType("int");

                    b.Property<bool>("IsParent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentFuneralHomeId")
                        .HasColumnType("int");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantId")
                        .HasColumnType("int");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VaultOrderId")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuneralHomeId");

                    b.HasIndex("VaultOrderId");

                    b.ToTable("FuneralHomes");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHomeContact", b =>
                {
                    b.Property<int>("FuneralHomeContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActiveTab")
                        .HasColumnType("int");

                    b.Property<string>("ContactRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuneralHomeId")
                        .HasColumnType("int");

                    b.Property<string>("Interests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneType3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("ShowPrices")
                        .HasColumnType("bit");

                    b.Property<string>("Spouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VaultOrderId")
                        .HasColumnType("int");

                    b.Property<string>("fhName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuneralHomeContactId");

                    b.HasIndex("FuneralHomeId");

                    b.HasIndex("VaultOrderId");

                    b.ToTable("FuneralHomeContacts");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Interaction", b =>
                {
                    b.Property<int>("InteractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Completed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FollowUpDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuneralHomeId")
                        .HasColumnType("int");

                    b.Property<string>("Nature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outcome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SelectedAnswer")
                        .HasColumnType("int");

                    b.Property<string>("fhName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InteractionId");

                    b.ToTable("Interactions");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.ParentFuneralHome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FunralHomeFuneralHomeId")
                        .HasColumnType("int");

                    b.Property<string>("ParentFuneralhomeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FunralHomeFuneralHomeId");

                    b.ToTable("ParentFuneralHomes");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CemetaryId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
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

                    b.Property<string>("PlantManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantManagerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantManagerTxtNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantNavigationFuneralHomeId")
                        .HasColumnType("int");

                    b.Property<bool>("PrintCompletedOrders")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VaultOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("VaultOrderId1")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("PlantId");

                    b.HasIndex("CemetaryId");

                    b.HasIndex("PlantNavigationFuneralHomeId");

                    b.HasIndex("VaultOrderId");

                    b.HasIndex("VaultOrderId1");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AllowedToSelectId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UpChargeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("UpChargeForLegacy")
                        .HasColumnType("bit");

                    b.Property<int?>("VaultOrderId")
                        .HasColumnType("int");

                    b.Property<string>("VenetianCarapace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("VaultOrderId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.ProductsOnVaultOrder", b =>
                {
                    b.Property<int>("ProductsOnVaultOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AllowedToSelectId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UpChargeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("UpChargeForLegacy")
                        .HasColumnType("bit");

                    b.Property<int>("VaultOrderId")
                        .HasColumnType("int");

                    b.Property<string>("VenetianCarapace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductsOnVaultOrderId");

                    b.ToTable("ProductsOnVaultOrder");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Truck", b =>
                {
                    b.Property<string>("TruckId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AcquisitionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DriverEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inactive")
                        .HasColumnType("bit");

                    b.Property<string>("InactiveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicPlateRenewal")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("PlantId");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.VaultOrder", b =>
                {
                    b.Property<int>("VaultOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AwningOverCasket")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("CemetaryId")
                        .HasColumnType("int");

                    b.Property<string>("CemetaryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CemetaryTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveringPlantId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveringPlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExtraChairs")
                        .HasColumnType("int");

                    b.Property<string>("Fdrequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FuneralDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuneralDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuneralHomeContactId")
                        .HasColumnType("int");

                    b.Property<int>("FuneralHomeId")
                        .HasColumnType("int");

                    b.Property<string>("GraveLocationSection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MilitarySetup")
                        .HasColumnType("bit");

                    b.Property<int>("OrderingPlantId")
                        .HasColumnType("int");

                    b.Property<string>("OrderingPlantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RegisterStand")
                        .HasColumnType("bit");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TentWith6Chairs")
                        .HasColumnType("bit");

                    b.Property<int?>("VaultId")
                        .HasColumnType("int");

                    b.Property<string>("VaultOrderNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VenetianCarapace")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("funeralhome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strCemeteryTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strFuneralDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaultOrderId");

                    b.ToTable("VaultOrder");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.ActiveVm", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Employee", null)
                        .WithMany("Answers")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Cemetary", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.VaultOrder", null)
                        .WithMany("lstCemetaries")
                        .HasForeignKey("VaultOrderId");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.CompletedVm", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Interaction", null)
                        .WithMany("Answers")
                        .HasForeignKey("InteractionId");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Employee", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Plant", "PlantEmployee")
                        .WithMany("Employees")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlantEmployee");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHome", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.VaultOrder", null)
                        .WithMany("FuneralHomes")
                        .HasForeignKey("VaultOrderId");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHomeContact", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", null)
                        .WithMany("Contacts")
                        .HasForeignKey("FuneralHomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WilbertVaultCompany.api.Models.VaultOrder", null)
                        .WithMany("Contacts")
                        .HasForeignKey("VaultOrderId");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.ParentFuneralHome", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", "FunralHomeFuneralHome")
                        .WithMany("ParentFuneralHomes")
                        .HasForeignKey("FunralHomeFuneralHomeId");

                    b.Navigation("FunralHomeFuneralHome");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Plant", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Cemetary", null)
                        .WithMany("Plants")
                        .HasForeignKey("CemetaryId");

                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", "PlantNavigation")
                        .WithMany("Plants")
                        .HasForeignKey("PlantNavigationFuneralHomeId");

                    b.HasOne("WilbertVaultCompany.api.Models.VaultOrder", null)
                        .WithMany("DeliveringPlant")
                        .HasForeignKey("VaultOrderId");

                    b.HasOne("WilbertVaultCompany.api.Models.VaultOrder", null)
                        .WithMany("OrderingPlant")
                        .HasForeignKey("VaultOrderId1");

                    b.Navigation("PlantNavigation");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Product", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.VaultOrder", null)
                        .WithMany("ProductsOnOrder")
                        .HasForeignKey("VaultOrderId");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Truck", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Plant", "AssignedPlant")
                        .WithMany("Trucks")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedPlant");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Cemetary", b =>
                {
                    b.Navigation("Plants");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Employee", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHome", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("ParentFuneralHomes");

                    b.Navigation("Plants");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Interaction", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Plant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Trucks");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.VaultOrder", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("DeliveringPlant");

                    b.Navigation("FuneralHomes");

                    b.Navigation("lstCemetaries");

                    b.Navigation("OrderingPlant");

                    b.Navigation("ProductsOnOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
