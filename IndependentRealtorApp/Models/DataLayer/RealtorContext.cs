/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace IndependentRealtorApp.Models.DataLayer
{
    public class RealtorContext : DbContext
    {
        // constructor to pass up to DbContext
        public RealtorContext(DbContextOptions<RealtorContext> options) : base(options) { } 

        public DbSet<Realtor> Realtors { get; set; }  // a one to many

        public DbSet<User> Users { get; set; }  // a one to many

        public DbSet<Property> Properties { get; set; }  // the many
        

    }
}
