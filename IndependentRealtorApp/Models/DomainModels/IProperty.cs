﻿namespace IndependentRealtorApp.Models.DomainModels
{
    public interface IProperty
    {
        public int PropertyId { get; set; }

        public string PropertyTitle { get; set; }

        public string PropertyDescription { get; set; }

        public string PropertyAddress { get; set; }

        public string PropertyCity { get; set; }

        public string PropertyState { get; set; }

        public string PropertyZip { get; set; }

        public string PropertyStatus { get; set; }

        public double? PropertyPrice { get; set; }

        public string? ImageUrl { get; set; }

        public Realtor? Realtor { get; set; }
        //string RealtorId { get; set; }

        public List<Property> GetProperties();

        // Navigation properties
        public List<PropertyUser>? PropertyUsers { get; set; }

        // new methods for admin area
        void Add(Property property);
        void Update(Property property);
        void Delete(Property property);
        public Property? GetPropertyById(int id);

    }
}