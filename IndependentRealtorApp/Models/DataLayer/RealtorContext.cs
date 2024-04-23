/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

using IndependentRealtorApp.Models.Configuration;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IndependentRealtorApp.Models
{
    public class RealtorContext : IdentityDbContext
    {
        // added for unit testing the UserService
        public RealtorContext() { }

        // constructor to pass up to DbContext
        public RealtorContext(DbContextOptions<RealtorContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!; // a one to many

        public DbSet<PropertyUser> PropertyUsers { get; set; } = null!; // the many

        public DbSet<Property> Properties { get; set; } = null!; // the many

        public DbSet<Realtor> Realtors { get; set; } = null!;  // a one to many


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the data via config files based on book example /Models/Configuration
            // order may be important - might have to switch these around
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new PropertyUserConfig());
            
            modelBuilder.ApplyConfiguration(new RealtorConfig());
            modelBuilder.ApplyConfiguration(new PropertyConfig());

            // adding Identity to the context
            base.OnModelCreating(modelBuilder); // this will include the default configurations needed for the identity entities primary keys
            modelBuilder.Entity<IdentityUserLogin<string>>();
        }
    }
}
