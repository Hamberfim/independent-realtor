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
    [Migration("20240425210717_FreshMigration")]
    partial class FreshMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.HasData(
                        new
                        {
                            PublicUserId = 1,
                            PropertyId = 1
                        },
                        new
                        {
                            PublicUserId = 2,
                            PropertyId = 1
                        },
                        new
                        {
                            PublicUserId = 1,
                            PropertyId = 2
                        },
                        new
                        {
                            PublicUserId = 3,
                            PropertyId = 2
                        },
                        new
                        {
                            PublicUserId = 4,
                            PropertyId = 3
                        },
                        new
                        {
                            PublicUserId = 7,
                            PropertyId = 3
                        },
                        new
                        {
                            PublicUserId = 5,
                            PropertyId = 4
                        },
                        new
                        {
                            PublicUserId = 6,
                            PropertyId = 4
                        },
                        new
                        {
                            PublicUserId = 5,
                            PropertyId = 5
                        },
                        new
                        {
                            PublicUserId = 3,
                            PropertyId = 5
                        },
                        new
                        {
                            PublicUserId = 2,
                            PropertyId = 6
                        },
                        new
                        {
                            PublicUserId = 4,
                            PropertyId = 6
                        },
                        new
                        {
                            PublicUserId = 1,
                            PropertyId = 7
                        },
                        new
                        {
                            PublicUserId = 7,
                            PropertyId = 7
                        });
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.PublicUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PublicUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Sam",
                            LastName = "Smith",
                            UserEmail = "ssmith@fakeworld.net",
                            UserName = "Sam",
                            UserPassword = "pass1"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Linda",
                            LastName = "Beltcher",
                            UserEmail = "lbeltcher@fakeworld.net",
                            UserName = "Linda",
                            UserPassword = "pass1"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Bob",
                            LastName = "Beltcher",
                            UserEmail = "bbeltcher@fakeworld.net",
                            UserName = "Bob",
                            UserPassword = "pass1"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Kathy",
                            LastName = "Klien",
                            UserEmail = "kklien@fakeworld.net",
                            UserName = "Kathy",
                            UserPassword = "pass1"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Billy",
                            LastName = "Williams",
                            UserEmail = "bwilliams@fakeworld.net",
                            UserName = "Billy",
                            UserPassword = "pass1"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Sarah",
                            LastName = "Seashell",
                            UserEmail = "sseashell@fakeworld.net",
                            UserName = "Sarah",
                            UserPassword = "pass1"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Steven",
                            LastName = "Klien",
                            UserEmail = "sklien@fakeworld.net",
                            UserName = "Steven",
                            UserPassword = "pass1"
                        });
                });

            modelBuilder.Entity("IndependentRealtorApp.Models.DomainModels.Realtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<string>("RealtorPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Realtors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Timothy",
                            LastName = "Goodsale",
                            RealtorEmail = "tgoodsale@fakerealty.com",
                            RealtorPassword = "pass2",
                            UserName = "Tim"
                        });
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
