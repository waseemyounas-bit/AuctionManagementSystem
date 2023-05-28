﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AMSModels.AddVehicleView", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdInfoRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CORType")
                        .HasColumnType("int");

                    b.Property<string>("DealerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OORMilegeRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReserveRemaks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TitleState")
                        .HasColumnType("int");

                    b.Property<int?>("TitleStatus")
                        .HasColumnType("int");

                    b.Property<int?>("VDamage")
                        .HasColumnType("int");

                    b.Property<string>("VDamageRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VSeller")
                        .HasColumnType("int");

                    b.Property<string>("Vaccident")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaccidentRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleLocated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehiclePurchaseMoth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehiclePurchaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vmiles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VownershipRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vtitled")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VtitledRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<string>("mileageDistanceUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("odometerreadingreflect")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AddVehicle");
                });

            modelBuilder.Entity("AMSModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IsApproved")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                            CreatedAt = new DateTime(2023, 5, 28, 10, 27, 0, 834, DateTimeKind.Utc).AddTicks(9225),
                            Email = "admin@auctionsystem.com",
                            FullName = "SuperAdmin",
                            IsApproved = 1,
                            Password = "12345678",
                            RoleId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
