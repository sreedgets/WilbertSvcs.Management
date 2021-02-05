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
    [Migration("20210205150924_chgDataTypesProduct")]
    partial class chgDataTypesProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("WilbertProductCompany.api.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
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

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.AnswerVm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AnswerVm");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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
                        .UseIdentityColumn();

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

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuneralHomeId");

                    b.ToTable("FuneralHomes");
                });

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHomeContact", b =>
                {
                    b.Property<int>("FuneralHomeContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.Property<string>("fhName")
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

                    b.Property<string>("Nature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outcome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

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
                        .UseIdentityColumn();

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
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("PlantId");

                    b.HasIndex("PlantNavigationFuneralHomeId");

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

            modelBuilder.Entity("WilbertVaultCompany.api.Models.AnswerVm", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.Employee", null)
                        .WithMany("Answers")
                        .HasForeignKey("EmployeeId");
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

            modelBuilder.Entity("WilbertVaultCompany.api.Models.FuneralHomeContact", b =>
                {
                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", null)
                        .WithMany("Contacts")
                        .HasForeignKey("FuneralHomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("WilbertVaultCompany.api.Models.FuneralHome", "PlantNavigation")
                        .WithMany("Plants")
                        .HasForeignKey("PlantNavigationFuneralHomeId");

                    b.Navigation("PlantNavigation");
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

            modelBuilder.Entity("WilbertVaultCompany.api.Models.Plant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Trucks");
                });
#pragma warning restore 612, 618
        }
    }
}
