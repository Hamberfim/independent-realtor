using System.ComponentModel.DataAnnotations;

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

        /* NOTE: this implementation in the admin models */
        // FIXME: | TODO: implement in a registration model/form
        //public string UserName { get; set; } = string.Empty;
        //public string UserPassword { get; set; } = string.Empty;

        // Navigation properties
        public List<PropertyUser>? PropertyUsers { get; set; }
    }
}
