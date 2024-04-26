﻿// <auto-generated />
using System;
using IndependentRealtorApp.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    [DbContext(typeof(RealtorContext))]
    [Migration("20240426220541_SeedCheck")]
    partial class SeedCheck
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IndependentRealtorApp.Models.DataLayer.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasKey("Id");

                    b.HasIndex("RealtorId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
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
                            Id = 2,
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
                            Id = 3,
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
                            Id = 4,
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
                            Id = 5,
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
                            Id = 6,
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
                            Id = 7,
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
                    b.Property<int>("PublicUserId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("PublicUserId", "PropertyId");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyUsers");
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.PublicUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "19ff4c95-16e3-47a6-b9b7-0336b2d2761c",
                            Email = "ssmith@fakeworld.net",
                            EmailConfirmed = false,
                            FirstName = "Sam",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Sam",
                            UserPassword = "pass1"
                        });
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Realtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RealtorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealtorPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Realtors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "439828df-f235-4538-9801-c63a0a96dc63",
                            EmailConfirmed = false,
                            FirstName = "Timothy",
                            LastName = "Goodsale",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            RealtorEmail = "tgoodsale@fakerealty.com",
                            RealtorPassword = "pass2",
                            TwoFactorEnabled = false,
                            UserName = "Tim"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

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
                        .OnDelete(DeleteBehavior.Cascade)
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

                    b.HasOne("IndependentRealtorApp.Models.DomainModels.PublicUser", "PublicUser")
                        .WithMany("PropertyUsers")
                        .HasForeignKey("PublicUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("PublicUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("IndependentRealtorApp.Models.DataLayer.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("IndependentRealtorApp.Models.DomainModels.PublicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("IndependentRealtorApp.Models.DomainModels.PublicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("IndependentRealtorApp.Models.DataLayer.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndependentRealtorApp.Models.DomainModels.PublicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("IndependentRealtorApp.Models.DomainModels.PublicUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Property", b =>
                {
                    b.Navigation("PropertyUsers");
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.PublicUser", b =>
                {
                    b.Navigation("PropertyUsers");
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Realtor", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
