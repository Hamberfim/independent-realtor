﻿/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

using IndependentRealtorApp.Models.Configuration;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace IndependentRealtorApp.Models.DataLayer
{
    public class RealtorContext : DbContext
    {
        // constructor to pass up to DbContext
        public RealtorContext(DbContextOptions<RealtorContext> options) : base(options) { }

        public DbSet<Property> Properties { get; set; } = null!; // the many

        public DbSet<Realtor> Realtors { get; set; } = null!;  // a one to many

        public DbSet<User> Users { get; set; } = null!; // a one to many


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the data via config files based on book example /Models/Configuration
            // order may be important - might have to switch these around
            modelBuilder.ApplyConfiguration(new PropertyConfig());
            modelBuilder.ApplyConfiguration(new RealtorConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());

        }
    }
}
