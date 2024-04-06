﻿using System.ComponentModel.DataAnnotations;

namespace IndependentRealtorApp.Models.DomainModels
{
    public class Property
    {
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
        [StringLength(5, ErrorMessage = "Property zip must be exactly 5 numeric characters.")]
        [Range(5, 5, ErrorMessage = "Property zip must be exactly 5 numeric characters.")]
        [Required(ErrorMessage = "Please enter a property zip.")]
        public string PropertyZip { get; set; } = string.Empty;

        [Display(Name = "Property Status")]
        [StringLength(10, ErrorMessage = "Property status must be 10 characters or less.")]
        [Required(ErrorMessage = "Please enter a property status (i.e.,  'for sale', 'pending', 'sold').")]
        public string PropertyStatus { get; set; } = string.Empty;  // could be a model with "for sale", "pending", "sold" etc.

        public string? imageUrl { get; set; } = string.Empty;  // fixed url to image dir, no upload functionality
    }
}
