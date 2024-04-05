/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IndependentRealtorApp.Models
{
    // some model names changed from original schema for additional clarity
    public class PublicUser
    {
        /* TODO: data annotations here or fluent API use in the DBContext seed file */

        [Key]
        public int PublicUserId { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; } = string.Empty;

        // MAYBE TODO: REGEX and/or check if email is already in DB
        [Required(ErrorMessage = "Please Enter an email address. Your email address will also be your user name.")]
        [Display(Name = "Email/User Name")]
        public string PublicUserNameEmail { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter a password.")]
        [Compare("ConfirmPassword")]
        [StringLength(25, ErrorMessage = "Password is limited to a maximum of 25 characters")]
        public string PublicUserPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [Display(Name = "Confirm Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; } = string.Empty;


        // from the other model (one PublicUser to many PropertyItems)
        public ICollection<PropertyItem> PropertyItems { get; set; } = null!;

    }
}
