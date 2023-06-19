﻿using AMSModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<AddVehicle> AddVehicle { get; set; }
        public DbSet<VehicleImages> VehicleImages { get; set; }
        public DbSet<PlaceBid> PlaceBid { get; set; }
        public DbSet<ContactMe> ContactMe { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<AddVehicle>().HasKey(x => x.AvId);
            modelBuilder.Entity<PlaceBid>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                    FullName = "SuperAdmin",
                    Email = "admin@auctionsystem.com",
                    Password = "12345678",
                    RoleId = 1,
                    IsApproved=1
                }
            );
            modelBuilder.Entity<Configuration>().HasData(
                new Configuration
                {
                    Id = new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                    MinAmount = 50,//Minimum amount for non reserved vehicles
                    AuctionDuration=7, //Days
                    BidStartPercentage=50 //Percentage
                }
            );
        }


    }
}
