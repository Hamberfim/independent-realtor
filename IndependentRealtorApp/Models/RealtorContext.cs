/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

using Microsoft.EntityFrameworkCore;

namespace IndependentRealtorApp.Models
{
    public class RealtorContext : DbContext
    {
        public RealtorContext(DbContextOptions<RealtorContext> options) : base(options) { }

        public DbSet<Realtor> Realtors { get; set; } = null!;  // one Realtor to many PropertyItems
        public DbSet<PublicUser> PublicUsers { get; set; } = null!;  // one PublicUser to many PropertyItems
        public DbSet<PropertyItem> PropertyItems { get; set; } = null!;

    }
}
