﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaiterAPI.DBContext;

namespace WaiterAPI.Migrations
{
    [DbContext(typeof(WaiterContext))]
    [Migration("20190601004014_FourthMigrate")]
    partial class FourthMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WaiterAPI.Models.Element", b =>
                {
                    b.Property<string>("ElementCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("GroupCode");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Remark");

                    b.Property<string>("Type");

                    b.Property<string>("UOM");

                    b.HasKey("ElementCode");

                    b.HasIndex("GroupCode");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("WaiterAPI.Models.ElementModifier", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ElementCode");

                    b.Property<string>("Remark");

                    b.HasKey("Code");

                    b.HasIndex("ElementCode");

                    b.ToTable("ElementModifiers");
                });

            modelBuilder.Entity("WaiterAPI.Models.Group", b =>
                {
                    b.Property<string>("GroupCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Remark");

                    b.Property<int>("Sequence");

                    b.Property<string>("Type");

                    b.HasKey("GroupCode");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("WaiterAPI.Models.LineItem", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("Element");

                    b.Property<string>("Quantity");

                    b.Property<string>("Remark");

                    b.Property<decimal>("TaxAmount");

                    b.Property<string>("TaxType");

                    b.Property<decimal>("TotalAmount");

                    b.Property<string>("UnitAmount");

                    b.Property<string>("VoucherCode");

                    b.HasKey("Code");

                    b.HasIndex("VoucherCode");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("WaiterAPI.Models.Person", b =>
                {
                    b.Property<string>("PersonCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Active");

                    b.Property<DateTime>("DateOFBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("Group");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.Property<string>("Remark");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.HasKey("PersonCode");

                    b.ToTable("Persons");

                    b.HasData(
                        new { PersonCode = "pe01", Active = "true", DateOFBirth = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), FirstName = "hannha", Gender = "Female", Group = "waitress", LastName = " ", MiddleName = "M", Nationality = "Etgiopian", Remark = "new", Title = "Ms.", Type = " " }
                    );
                });

            modelBuilder.Entity("WaiterAPI.Models.PhysicalTable", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("LocationCode");

                    b.Property<int>("MaxOccupancy");

                    b.Property<string>("RankCode");

                    b.Property<string>("Remark");

                    b.HasKey("Code");

                    b.ToTable("PhysicalTables");
                });

            modelBuilder.Entity("WaiterAPI.Models.price", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Currency");

                    b.Property<string>("Decription");

                    b.Property<string>("ElementCode");

                    b.Property<bool>("IsDefault");

                    b.Property<decimal>("PriceValue");

                    b.Property<string>("Remark");

                    b.Property<int>("priority");

                    b.HasKey("Code");

                    b.HasIndex("ElementCode");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("WaiterAPI.Models.User", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<string>("PersonCode");

                    b.Property<int>("loggedInStatus");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("Code");

                    b.HasIndex("PersonCode");

                    b.ToTable("Users");

                    b.HasData(
                        new { Code = "us01", IsActive = true, PersonCode = "pe01", loggedInStatus = 0, password = "h123", username = "hab" }
                    );
                });

            modelBuilder.Entity("WaiterAPI.Models.Voucher", b =>
                {
                    b.Property<string>("VoucherCode")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<bool>("IsIssued");

                    b.Property<bool>("IsVoid");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Type");

                    b.Property<string>("Unit");

                    b.Property<string>("VoucherTo");

                    b.Property<string>("remark");

                    b.HasKey("VoucherCode");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("WaiterAPI.Models.VoucherExtensionRestaurant", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PhysicalTableCode");

                    b.Property<string>("Remark");

                    b.Property<string>("VoucherCode");

                    b.Property<string>("waiter");

                    b.HasKey("Code");

                    b.HasIndex("VoucherCode");

                    b.ToTable("VoucherExtensionRestaurants");
                });

            modelBuilder.Entity("WaiterAPI.Models.Element", b =>
                {
                    b.HasOne("WaiterAPI.Models.Group", "group")
                        .WithMany()
                        .HasForeignKey("GroupCode");
                });

            modelBuilder.Entity("WaiterAPI.Models.ElementModifier", b =>
                {
                    b.HasOne("WaiterAPI.Models.Element", "element")
                        .WithMany()
                        .HasForeignKey("ElementCode");
                });

            modelBuilder.Entity("WaiterAPI.Models.LineItem", b =>
                {
                    b.HasOne("WaiterAPI.Models.Voucher", "voucher")
                        .WithMany()
                        .HasForeignKey("VoucherCode");
                });

            modelBuilder.Entity("WaiterAPI.Models.price", b =>
                {
                    b.HasOne("WaiterAPI.Models.Element", "element")
                        .WithMany()
                        .HasForeignKey("ElementCode");
                });

            modelBuilder.Entity("WaiterAPI.Models.User", b =>
                {
                    b.HasOne("WaiterAPI.Models.Person", "person")
                        .WithMany()
                        .HasForeignKey("PersonCode");
                });

            modelBuilder.Entity("WaiterAPI.Models.VoucherExtensionRestaurant", b =>
                {
                    b.HasOne("WaiterAPI.Models.Voucher", "voucher")
                        .WithMany()
                        .HasForeignKey("VoucherCode");
                });
#pragma warning restore 612, 618
        }
    }
}
