using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IndependentRealtorApp.Models.DomainModels
{
    public class User
    {
        /* NOTE: Implemented in UserService.cs */

        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(50, ErrorMessage = "First name must be 50 characters or less.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(50, ErrorMessage = "Last name must be 50 characters or less.")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string UserEmail { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        /* NOTE: this implementation in the user and admin models */
        [Required(ErrorMessage = "Please enter user name.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter to confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; } = string.Empty;

        // Navigation properties
        public List<PropertyUser>? PropertyUsers { get; set; }
    }
}
