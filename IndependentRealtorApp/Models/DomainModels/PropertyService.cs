using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace IndependentRealtorApp.Models.DomainModels
{
    public class PropertyService : IProperty
    {
        private readonly RealtorContext _context;

        public PropertyService(RealtorContext ctx)
        {
            _context = ctx;
        }

        public int PropertyId { get; set; }

        [Display(Name = "Property Title")]
        [StringLength(200, ErrorMessage = "Property title must be 200 characters or less.")]
        [Required(ErrorMessage = "Please enter a property title.")]
        public string PropertyTitle { get; set; } = string.Empty;

        [Display(Name = "Property Description")]
        [Required(ErrorMessage = "Please enter a description title.")]
        public string PropertyDescription { get; set; } = string.Empty;

        [Display(Name = "Property Address")]
        [StringLength(225, ErrorMessage = "Property address must be 225 characters or less.")]
        [Required(ErrorMessage = "Please enter a property address.")]
        public string PropertyAddress { get; set; } = string.Empty;

        [Display(Name = "Property City")]
        [StringLength(35, ErrorMessage = "Property city must be 35 characters or less.")]
        [Required(ErrorMessage = "Please enter a property city.")]
        public string PropertyCity { get; set; } = string.Empty;

        [Display(Name = "Property State")]
        [StringLength(2, ErrorMessage = "Property state must be the two character abbreviation (i.e., Iowa = IA, Texas = TX).")]
        [Required(ErrorMessage = "Please enter a property state abbreviation.")]
        public string PropertyState { get; set; } = string.Empty;

        [Display(Name = "Property Zip")]
        [Required(ErrorMessage = "Please enter a property zip.")]
        public string PropertyZip { get; set; } = string.Empty;

        [Display(Name = "Property Status")]
        [StringLength(10, ErrorMessage = "Property status must be 10 characters or less.")]
        [Required(ErrorMessage = "Please enter a property status (i.e.,  'for sale', 'pending', 'sold').")]
        public string PropertyStatus { get; set; } = string.Empty;  // could be a model with "for sale", "pending", "sold" etc.

        [Display(Name = "Property Price")]
        [Required(ErrorMessage = "Please enter the property price.")]
        [Range(1.0, 999999999, ErrorMessage = "Price must be greater than zero but less than 999,999,999.")]
        public double? PropertyPrice { get; set; }

        public string? ImageUrl { get; set; } = "..image to come.";

        //public string RealtorId { get; set; } = string.Empty;

        [ValidateNever]
        public Realtor? Realtor { get; set; }

        // Navigation properties
        public List<PropertyUser>? PropertyUsers { get; set; }

        public List<Property> GetProperties() =>
            // return new List<Property>();
            _context.Properties.ToList();

        public Property? GetPropertyById(int id)
        {
            return _context.Properties.FirstOrDefault(p => p.PropertyId == id);
        }

        // new methods for admin area
        public void Add(Property property)
        {
            _context.Properties.Add(property);
            _context.SaveChanges();
        }

        public void Update(Property property)
        {
            _context.Properties.Update(property);
            _context.SaveChanges();
        }

        public void Delete(Property property)
        {
            _context.Properties.Remove(property);
            _context.SaveChanges();
        }
    }
}
