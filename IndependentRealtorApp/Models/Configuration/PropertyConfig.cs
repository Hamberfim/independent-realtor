using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel;

namespace IndependentRealtorApp.Models.Configuration
{
    public class PropertyConfig : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> entity)
        {
            // fluent API - restrict delete behavior on realtor of one to many
            entity.HasOne(p => p.Realtor)
                .WithMany(r => r.Properties)
                .OnDelete(DeleteBehavior.Restrict);

            // data
            entity.HasData(
                    new Property
                    {
                        PropertyId = 1,
                        PropertyTitle = "Cottage Bungalow",
                        PropertyDescription = "3 bedroom, 2 bath cottage styled bungalow",
                        PropertyAddress = "1234 Olive St.",
                        PropertyCity = "Anytown",
                        PropertyState = "IA",
                        PropertyZip = "50266",
                        PropertyStatus = "for sale",
                        imageUrl = "images/1234olive.jpg",
                        PropertyPrice = 215000.00,
                        RealtorId = 1
                    },
                    new Property
                    {
                        PropertyId = 2,
                        PropertyTitle = "Deco Two Story",
                        PropertyDescription = "5 bedroom, 2.5 bath turn of the century deco styled two story",
                        PropertyAddress = "5561 Art Nuevo Ave.",
                        PropertyCity = "Sometown",
                        PropertyState = "IA",
                        PropertyZip = "50266",
                        PropertyStatus = "for sale",
                        imageUrl = "images/5561artnuevo.jpg",
                        PropertyPrice = 450000.00,
                        RealtorId = 1
                    },
                    new Property
                    {
                        PropertyId = 3,
                        PropertyTitle = "Ranch Acreage",
                        PropertyDescription = "4 bedroom, 2 bath ranch acreage",
                        PropertyAddress = "12 Gravel Rd.",
                        PropertyCity = "Ruraltown",
                        PropertyState = "IA",
                        PropertyZip = "50266",
                        PropertyStatus = "pending",
                        imageUrl = "images/12gravel.jpg",
                        PropertyPrice = 385000.00,
                        RealtorId = 1
                    },
                    new Property
                    {
                        PropertyId = 4,
                        PropertyTitle = "Two bedroom Bungalow",
                        PropertyDescription = "2 bedroom, 1.5 bath bungalow",
                        PropertyAddress = "321 Corinda St",
                        PropertyCity = "Anytown",
                        PropertyState = "NY",
                        PropertyZip = "12345",
                        PropertyStatus = "for sale",
                        imageUrl = "images/321corinda.jpg",
                        PropertyPrice = 205000.00,
                        RealtorId = 1
                    },
                    new Property
                    {
                        PropertyId = 5,
                        PropertyTitle = "Stylish Townhome",
                        PropertyDescription = "3 bedroom, 2 bath Stylish Townhome",
                        PropertyAddress = "756 Lincoln Blvd.",
                        PropertyCity = "Metro-City",
                        PropertyState = "IA",
                        PropertyZip = "55555",
                        PropertyStatus = "for sale",
                        imageUrl = "images/756lincoln.jpg",
                        PropertyPrice = 279900.00,
                        RealtorId = 1
                    },
                    new Property
                    {
                        PropertyId = 6,
                        PropertyTitle = "17 acres for development",
                        PropertyDescription = "17 undeveloped acres just west of the city.",
                        PropertyAddress = "5 West Woods Rd",
                        PropertyCity = "Anytown",
                        PropertyState = "IA",
                        PropertyZip = "55555",
                        PropertyStatus = "for sale",
                        imageUrl = "images/5westwoods.jpg",
                        PropertyPrice = 86700.00,
                        RealtorId = 1
                    },
                    new Property
                    {
                        PropertyId = 7,
                        PropertyTitle = "Charming home close to downtown",
                        PropertyDescription = "2 bedroom, 2 bath just minutes from downtown.",
                        PropertyAddress = "16 East Prosaic St",
                        PropertyCity = "Metro-City",
                        PropertyState = "IA",
                        PropertyZip = "55555",
                        PropertyStatus = "for sale",
                        imageUrl = "images/16east.jpg",
                        PropertyPrice = 199900.00,
                        RealtorId = 1
                    }
               );
        }
    }

}
