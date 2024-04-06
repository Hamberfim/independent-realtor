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
        public DbSet<PublicUser> PublicUsers { get; set; }  // one PublicUser to many PropertyItems
        public DbSet<PropertyItem> PropertyItems { get; set; } = null!;


        // seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PropertyItems
            //modelBuilder.Entity<PropertyItem>().HasOne(r => r.Realtor).WithMany(p => p.PropertyItems);
            modelBuilder.Entity<PropertyItem>().HasMany(p => p.PublicUsers).WithMany(p => p.PropertyItems);
            modelBuilder.Entity<PropertyItem>().HasData(
                    new PropertyItem
                    {
                        PropertyItemId = 1,
                        PropertyItemTitle = "3 bedroom, 2 bath, 2 car garage",
                        PropertyItemDescription = "Cottage Styled 3 bed, 2 bath, with a 2 car garage.",
                        PropertyItemAddress = "123 Oak St",
                        PropertyItemCity = "Somewhere",
                        PropertyItemState = "IA",
                        PropertyItemZip = "50266",
                        PropertyItemStatus = "For Sale",  // could be a model with property fields of "for sale", "pending", "sold", "for rental?"
                        imageUrl = "images/123oak.jpg",
                        RealtorId = 1,
                        
                    },
                    new PropertyItem
                    {
                        PropertyItemId = 2,
                        PropertyItemTitle = "4 bed, 3 bath, 3 car garage",
                        PropertyItemDescription = "Ranch Styled 4 bed, 3 bath, with a 3 car garage.",
                        PropertyItemAddress = "456 Maple Ave",
                        PropertyItemCity = "Somewhere",
                        PropertyItemState = "IA",
                        PropertyItemZip = "50266",
                        PropertyItemStatus = "Pending",
                        imageUrl = "images/456maple.jpg",
                        RealtorId = 1,

                    },
                    new PropertyItem
                    {
                        PropertyItemId = 3,
                        PropertyItemTitle = "4 bed, 2.5 bath",
                        PropertyItemDescription = "Two Story 4 bed, 2.5 bath, with a car port and large back yard.",
                        PropertyItemAddress = "789 Elm St",
                        PropertyItemCity = "Somewhere",
                        PropertyItemState = "IA",
                        PropertyItemZip = "50266",
                        PropertyItemStatus = "For Sale",
                        imageUrl = "images/789elm.jpg",
                        RealtorId = 1,

                    },
                    new PropertyItem
                    {
                        PropertyItemId = 4,
                        PropertyItemTitle = "3 bed, 1.5 bath on an acreage.",
                        PropertyItemDescription = "Farm home 3 bed, 2 bath, on an acreage.",
                        PropertyItemAddress = "812 gravel Rd",
                        PropertyItemCity = "Ruraltown",
                        PropertyItemState = "IA",
                        PropertyItemZip = "50266",
                        PropertyItemStatus = "For Sale",
                        imageUrl = "images/812gravel.jpg",
                        RealtorId = 1,
                       
                    }
                );

            // realtor 
            modelBuilder.Entity<Realtor>().HasData(
                     new Realtor
                     {
                         RealtorId = 1,
                         FirstName = "Timothy",
                         LastName = "Goodsale",
                         UserNameEmail = "tgoodsale@fakerealty.com",
                         Password = "password",
                         imageUrl = "images/tgoodsale.jpg",
                         // one to many as a list of PropertyItems?

                     }
                );

            // public user
            modelBuilder.Entity<PublicUser>().HasData(
                     new PublicUser
                     {
                         PublicUserId = 1,
                         FirstName = "Kimmy",
                         LastName = "Klein",
                         PublicUserNameEmail = "kklein@fakeworld.net",
                         PublicUserPassword = "password"
                     },
                     new PublicUser
                     {
                         PublicUserId = 2,
                         FirstName = "Billy",
                         LastName = "Williams",
                         PublicUserNameEmail = "bwilliams@fakeworld.net",
                         PublicUserPassword = "password"
                     },
                     new PublicUser
                     {
                         PublicUserId = 3,
                         FirstName = "Sal",
                         LastName = "Scarapini",
                         PublicUserNameEmail = "sscarapini@fakeworld.net",
                         PublicUserPassword = "password"
                     },
                     new PublicUser
                     {
                         PublicUserId = 4,
                         FirstName = "Shelly",
                         LastName = "Seashell",
                         PublicUserNameEmail = "sseashell@fakeworld.net",
                         PublicUserPassword = "password"
                     }
                );

        }

    }
}
