/* Name: independent-realtor
* Authors: Anthony Hamlin, Brody Boell, Cole Cooley
* CIS174 - Final Project - Spring 2024
* NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
*/
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IndependentRealtorApp.Area.Admin.Models;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace IndependentRealtorApp.Models.DataLayer
{
    public class RealtorContext : IdentityDbContext<Realtor, IdentityRole<int>, int>
    {
        public RealtorContext() { }

        // constructor to pass up to DbContext
        public RealtorContext(DbContextOptions<RealtorContext> options) : base(options) { }

        // implemented through IdentityDbContext
        public DbSet<Realtor> Realtors { get; set; }// = null!;  // a one to many

        public DbSet<Property> Properties { get; set; }// = null!; // the many

        public DbSet<PublicUser> PublicUsers { get; set; }// = null!; // a one to many

        public DbSet<PropertyUser> PropertyUsers { get; set; }// = null!; // the many

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // adding Identity to the context
            base.OnModelCreating(modelBuilder); // this will include the default configurations needed for the identity entities primary keys
            //modelBuilder.Entity<IdentityUserLogin<string>>();

            // order may be important - might have to switch these around
            /* PROPERTY CONFIG & SEED DATA */
            modelBuilder.Entity<Property>().HasOne(p => p.Realtor).WithMany(r => r.Properties).HasForeignKey(p => p.RealtorId);
            modelBuilder.Entity<Property>().HasMany(p => p.PropertyUsers).WithOne(pu => pu.Property).HasForeignKey(pu => pu.PropertyId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Property>().HasData(
                    new Property
                    {
                        Id = 1,
                        PropertyTitle = "Cottage Bungalow",
                        PropertyDescription = "3 bedroom, 2 bath cottage styled bungalow",
                        PropertyAddress = "1234 Olive St.",
                        PropertyCity = "Anytown",
                        PropertyState = "IA",
                        PropertyZip = "50266",
                        PropertyStatus = "for sale",
                        ImageUrl = "images/1234olive.jpg",
                        PropertyPrice = 215000.00,
                        RealtorId = 1,


                    },
                    new Property
                    {
                        Id = 2,
                        PropertyTitle = "Deco Two Story",
                        PropertyDescription = "5 bedroom, 2.5 bath turn of the century deco styled two story",
                        PropertyAddress = "5561 Art Nuevo Ave.",
                        PropertyCity = "Sometown",
                        PropertyState = "IA",
                        PropertyZip = "50266",
                        PropertyStatus = "for sale",
                        ImageUrl = "images/5561artnuevo.jpg",
                        PropertyPrice = 450000.00,
                        RealtorId = 1,

                    },
                    new Property
                    {
                        Id = 3,
                        PropertyTitle = "Ranch Acreage",
                        PropertyDescription = "4 bedroom, 2 bath ranch acreage",
                        PropertyAddress = "12 Gravel Rd.",
                        PropertyCity = "Ruraltown",
                        PropertyState = "IA",
                        PropertyZip = "50266",
                        PropertyStatus = "pending",
                        ImageUrl = "images/12gravel.jpg",
                        PropertyPrice = 385000.00,
                        RealtorId = 1,

                    },
                    new Property
                    {
                        Id = 4,
                        PropertyTitle = "Two bedroom Bungalow",
                        PropertyDescription = "2 bedroom, 1.5 bath bungalow",
                        PropertyAddress = "321 Corinda St",
                        PropertyCity = "Anytown",
                        PropertyState = "NY",
                        PropertyZip = "12345",
                        PropertyStatus = "for sale",
                        ImageUrl = "images/321corinda.jpg",
                        PropertyPrice = 205000.00,
                        RealtorId = 1,

                    },
                    new Property
                    {
                        Id = 5,
                        PropertyTitle = "Stylish Townhome",
                        PropertyDescription = "3 bedroom, 2 bath Stylish Townhome",
                        PropertyAddress = "756 Lincoln Blvd.",
                        PropertyCity = "Metro-City",
                        PropertyState = "IA",
                        PropertyZip = "55555",
                        PropertyStatus = "for sale",
                        ImageUrl = "images/756lincoln.jpg",
                        PropertyPrice = 279900.00,
                        RealtorId = 1,

                    },
                    new Property
                    {
                        Id = 6,
                        PropertyTitle = "17 acres for development",
                        PropertyDescription = "17 undeveloped acres just west of the city.",
                        PropertyAddress = "5 West Woods Rd",
                        PropertyCity = "Anytown",
                        PropertyState = "IA",
                        PropertyZip = "55555",
                        PropertyStatus = "for sale",
                        ImageUrl = "images/5westwoods.jpg",
                        PropertyPrice = 86700.00,
                        RealtorId = 1,

                    },
                    new Property
                    {
                        Id = 7,
                        PropertyTitle = "Charming home close to downtown",
                        PropertyDescription = "2 bedroom, 2 bath just minutes from downtown.",
                        PropertyAddress = "16 East Prosaic St",
                        PropertyCity = "Metro-City",
                        PropertyState = "IA",
                        PropertyZip = "55555",
                        PropertyStatus = "for sale",
                        ImageUrl = "images/16east.jpg",
                        PropertyPrice = 199900.00,
                        RealtorId = 1,

                    }
               );

            /* PROPERTYUSER CONFIG & SEED DATA */
            modelBuilder.Entity<PropertyUser>().HasKey(pu => new { pu.PublicUserId, pu.PropertyId });

            //modelBuilder.Entity<PropertyUser>().HasOne(pu => pu.PublicUser).WithMany(u => u.PropertyUserLinks).HasForeignKey(pu => pu.PublicUserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PropertyUser>().HasOne(pu => pu.PublicUser).WithMany().HasForeignKey(pu => pu.PublicUserId).OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<PropertyUser>().HasOne(pu => pu.Property).WithMany(p => p.PropertyUsers).HasForeignKey(pu => pu.PropertyId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PropertyUser>().HasOne(pu => pu.Property).WithMany().HasForeignKey(pu => pu.PropertyId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Property>().HasMany(p => p.PropertyUsers).WithOne(pu => pu.Property).HasForeignKey(pu => pu.PropertyId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PropertyUser>().HasData(
                new PropertyUser { PropertyId = 1, PublicUserId = 1 },
                new PropertyUser { PropertyId = 1, PublicUserId = 2 },
                new PropertyUser { PropertyId = 2, PublicUserId = 1 },
                new PropertyUser { PropertyId = 2, PublicUserId = 3 },
                new PropertyUser { PropertyId = 3, PublicUserId = 4 },
                new PropertyUser { PropertyId = 3, PublicUserId = 7 },
                new PropertyUser { PropertyId = 4, PublicUserId = 5 },
                new PropertyUser { PropertyId = 4, PublicUserId = 6 },
                new PropertyUser { PropertyId = 5, PublicUserId = 5 },
                new PropertyUser { PropertyId = 5, PublicUserId = 3 },
                new PropertyUser { PropertyId = 6, PublicUserId = 2 },
                new PropertyUser { PropertyId = 6, PublicUserId = 4 },
                new PropertyUser { PropertyId = 7, PublicUserId = 1 },
                new PropertyUser { PropertyId = 7, PublicUserId = 7 }
                );


            /* REALTOR SEED DATA */
            modelBuilder.Entity<Realtor>().HasData(
                    // only one realtor for now
                    new Realtor { Id = 1, FirstName = "Timothy", LastName = "Goodsale", RealtorEmail = "tgoodsale@fakerealty.com", UserName = "Tim", RealtorPassword = "pass2" }
                );


            /* USER SEED DATA */
            modelBuilder.Entity<PublicUser>().HasMany(pu => pu.PropertyUsers).WithOne(pu => pu.PublicUser).HasForeignKey(pu => pu.PublicUserId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PublicUser>().Ignore(pu => pu.PropertyUserLinks);

            modelBuilder.Entity<Property>().HasMany(p => p.PropertyUsers).WithOne(pu => pu.Property).HasForeignKey(pu => pu.PropertyId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PublicUser>().HasData(
                new PublicUser { Id = 1, FirstName = "Sam", LastName = "Smith", UserEmail = "ssmith@fakeworld.net", UserName = "Sam", UserPassword = "pass1" },
                new PublicUser { Id = 2, FirstName = "Linda", LastName = "Beltcher", UserEmail = "lbeltcher@fakeworld.net", UserName = "Linda", UserPassword = "pass1" },
                new PublicUser { Id = 3, FirstName = "Bob", LastName = "Beltcher", UserEmail = "bbeltcher@fakeworld.net", UserName = "Bob", UserPassword = "pass1" },
                new PublicUser { Id = 4, FirstName = "Kathy", LastName = "Klien", UserEmail = "kklien@fakeworld.net", UserName = "Kathy", UserPassword = "pass1" },
                new PublicUser { Id = 5, FirstName = "Billy", LastName = "Williams", UserEmail = "bwilliams@fakeworld.net", UserName = "Billy", UserPassword = "pass1" },
                new PublicUser { Id = 6, FirstName = "Sarah", LastName = "Seashell", UserEmail = "sseashell@fakeworld.net", UserName = "Sarah", UserPassword = "pass1" },
                new PublicUser { Id = 7, FirstName = "Steven", LastName = "Klien", UserEmail = "sklien@fakeworld.net", UserName = "Steven", UserPassword = "pass1" }
                );

        }


        //public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        //{
        //    using (var scoped = serviceProvider.CreateScope())
        //    {
        //        UserManager<Realtor> userManager = scoped.ServiceProvider.GetRequiredService<UserManager<Realtor>>();
        //        RoleManager<IdentityRole> roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        string username = "admin";
        //        string pwd = "admin";
        //        string roleName = "Admin";

        //        // if role doesn't exist, create it
        //        if (await roleManager.FindByNameAsync(roleName) == null)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole(roleName));
        //        }

        //        if (await userManager.FindByNameAsync(username) == null)
        //        {
        //            Realtor user = new Realtor() { UserName = username };
        //            var result = await userManager.CreateAsync(user, pwd);
        //            if (result.Succeeded)
        //            {
        //                await userManager.AddToRoleAsync(user, roleName);
        //            }
        //        }
        //    }
        //}
    }
}