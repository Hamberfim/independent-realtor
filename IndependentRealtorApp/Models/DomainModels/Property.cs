using IndependentRealtorApp.Models.DataLayer;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IndependentRealtorApp.Models.DomainModels
{
    public class Property
    { 
        public int Id { get; set; }

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
        public string PropertyStatus { get; set; } = string.Empty;  

        [Display(Name = "Property Price")]
        [Required(ErrorMessage = "Please enter the property price.")]
        [Range(1.0, 999999999, ErrorMessage = "Price must be greater than zero but less than 999,999,999.")]
        public double? PropertyPrice { get; set; }


        public string? ImageUrl { get; set; } = "..image to come.";

        public int RealtorId { get; set; }

        [ValidateNever]
        public Realtor? Realtor { get; set; }  // navigation property

        public List<PropertyUser>? PropertyUsers { get; set; }

        // read only slug property
        public string Slug
        {
            get
            {
                return PropertyTitle.ToLower().Replace(" ", "-");
            }
        }
    }
}
