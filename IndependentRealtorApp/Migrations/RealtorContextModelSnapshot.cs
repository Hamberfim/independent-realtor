﻿// <auto-generated />
using System;
using IndependentRealtorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    [DbContext(typeof(RealtorContext))]
    partial class RealtorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyAddress")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("PropertyCity")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("PropertyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PropertyPrice")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("PropertyState")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("PropertyStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PropertyTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PropertyZip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RealtorId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.HasIndex("RealtorId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            PropertyId = 1,
                            ImageUrl = "images/1234olive.jpg",
                            PropertyAddress = "1234 Olive St.",
                            PropertyCity = "Anytown",
                            PropertyDescription = "3 bedroom, 2 bath cottage styled bungalow",
                            PropertyPrice = 215000.0,
                            PropertyState = "IA",
                            PropertyStatus = "for sale",
                            PropertyTitle = "Cottage Bungalow",
                            PropertyZip = "50266",
                            RealtorId = 1
                        },
                        new
                        {
                            PropertyId = 2,
                            ImageUrl = "images/5561artnuevo.jpg",
                            PropertyAddress = "5561 Art Nuevo Ave.",
                            PropertyCity = "Sometown",
                            PropertyDescription = "5 bedroom, 2.5 bath turn of the century deco styled two story",
                            PropertyPrice = 450000.0,
                            PropertyState = "IA",
                            PropertyStatus = "for sale",
                            PropertyTitle = "Deco Two Story",
                            PropertyZip = "50266",
                            RealtorId = 1
                        },
                        new
                        {
                            PropertyId = 3,
                            ImageUrl = "images/12gravel.jpg",
                            PropertyAddress = "12 Gravel Rd.",
                            PropertyCity = "Ruraltown",
                            PropertyDescription = "4 bedroom, 2 bath ranch acreage",
                            PropertyPrice = 385000.0,
                            PropertyState = "IA",
                            PropertyStatus = "pending",
                            PropertyTitle = "Ranch Acreage",
                            PropertyZip = "50266",
                            RealtorId = 1
                        },
                        new
                        {
                            PropertyId = 4,
                            ImageUrl = "images/321corinda.jpg",
                            PropertyAddress = "321 Corinda St",
                            PropertyCity = "Anytown",
                            PropertyDescription = "2 bedroom, 1.5 bath bungalow",
                            PropertyPrice = 205000.0,
                            PropertyState = "NY",
                            PropertyStatus = "for sale",
                            PropertyTitle = "Two bedroom Bungalow",
                            PropertyZip = "12345",
                            RealtorId = 1
                        },
                        new
                        {
                            PropertyId = 5,
                            ImageUrl = "images/756lincoln.jpg",
                            PropertyAddress = "756 Lincoln Blvd.",
                            PropertyCity = "Metro-City",
                            PropertyDescription = "3 bedroom, 2 bath Stylish Townhome",
                            PropertyPrice = 279900.0,
                            PropertyState = "IA",
                            PropertyStatus = "for sale",
                            PropertyTitle = "Stylish Townhome",
                            PropertyZip = "55555",
                            RealtorId = 1
                        },
                        new
                        {
                            PropertyId = 6,
                            ImageUrl = "images/5westwoods.jpg",
                            PropertyAddress = "5 West Woods Rd",
                            PropertyCity = "Anytown",
                            PropertyDescription = "17 undeveloped acres just west of the city.",
                            PropertyPrice = 86700.0,
                            PropertyState = "IA",
                            PropertyStatus = "for sale",
                            PropertyTitle = "17 acres for development",
                            PropertyZip = "55555",
                            RealtorId = 1
                        },
                        new
                        {
                            PropertyId = 7,
                            ImageUrl = "images/16east.jpg",
                            PropertyAddress = "16 East Prosaic St",
                            PropertyCity = "Metro-City",
                            PropertyDescription = "2 bedroom, 2 bath just minutes from downtown.",
                            PropertyPrice = 199900.0,
                            PropertyState = "IA",
                            PropertyStatus = "for sale",
                            PropertyTitle = "Charming home close to downtown",
                            PropertyZip = "55555",
                            RealtorId = 1
                        });
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.PropertyUser", b =>
                {
                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("PropertyUsers");

                    b.HasData(
                        new
                        {
                            PropertyId = 1,
                            UserId = 1
                        },
                        new
                        {
                            PropertyId = 1,
                            UserId = 2
                        },
                        new
                        {
                            PropertyId = 2,
                            UserId = 1
                        },
                        new
                        {
                            PropertyId = 2,
                            UserId = 3
                        },
                        new
                        {
                            PropertyId = 3,
                            UserId = 4
                        },
                        new
                        {
                            PropertyId = 3,
                            UserId = 7
                        },
                        new
                        {
                            PropertyId = 4,
                            UserId = 5
                        },
                        new
                        {
                            PropertyId = 4,
                            UserId = 6
                        },
                        new
                        {
                            PropertyId = 5,
                            UserId = 5
                        },
                        new
                        {
                            PropertyId = 5,
                            UserId = 3
                        },
                        new
                        {
                            PropertyId = 6,
                            UserId = 2
                        },
                        new
                        {
                            PropertyId = 6,
                            UserId = 4
                        },
                        new
                        {
                            PropertyId = 7,
                            UserId = 1
                        },
                        new
                        {
                            PropertyId = 7,
                            UserId = 7
                        });
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Realtor", b =>
                {
                    b.Property<int>("RealtorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RealtorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("RealtorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RealtorId");

                    b.ToTable("Realtors");

                    b.HasData(
                        new
                        {
                            RealtorId = 1,
                            FirstName = "Timothy",
                            LastName = "Goodsale",
                            RealtorEmail = "tgoodsale@fakerealty.com"
                        });
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Sam",
                            LastName = "Smith",
                            UserEmail = "ssmith@fakeworld.net"
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "Linda",
                            LastName = "Beltcher",
                            UserEmail = "lbeltcher@fakeworld.net"
                        },
                        new
                        {
                            UserId = 3,
                            FirstName = "Bob",
                            LastName = "Beltcher",
                            UserEmail = "bbeltcher@fakeworld.net"
                        },
                        new
                        {
                            UserId = 4,
                            FirstName = "Kathy",
                            LastName = "Klien",
                            UserEmail = "kklien@fakeworld.net"
                        },
                        new
                        {
                            UserId = 5,
                            FirstName = "Billy",
                            LastName = "Williams",
                            UserEmail = "bwilliams@fakeworld.net"
                        },
                        new
                        {
                            UserId = 6,
                            FirstName = "Sarah",
                            LastName = "Seashell",
                            UserEmail = "sseashell@fakeworld.net"
                        },
                        new
                        {
                            UserId = 7,
                            FirstName = "Steven",
                            LastName = "Klien",
                            UserEmail = "sklien@fakeworld.net"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Property", b =>
                {
                    b.HasOne("IndependentRealtorApp.Models.DomainModels.Realtor", "Realtor")
                        .WithMany("Properties")
                        .HasForeignKey("RealtorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Realtor");
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.PropertyUser", b =>
                {
                    b.HasOne("IndependentRealtorApp.Models.DomainModels.Property", "Property")
                        .WithMany("PropertyUsers")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndependentRealtorApp.Models.DomainModels.User", "User")
                        .WithMany("PropertyUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Property", b =>
                {
                    b.Navigation("PropertyUsers");
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Realtor", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.User", b =>
                {
                    b.Navigation("PropertyUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
