using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace IndependentRealtorApp.Models.DomainModels
{
    public class User
    {
        // when I construct the User object, I want to initialize the Properties collection
        public User() => Properties = new HashSet<Property>();  // HashSet is a collection type that doesn't allow duplicates

        public int UserId { get; set; }
        [Display(Name = "First Name")]
        [StringLength(125, ErrorMessage = "First name must be 125 characters or less")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(125, ErrorMessage = "Last name must be 125 characters or less")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";  // read-only property

        [Display(Name = "User Email")]
        [Required(ErrorMessage = "Please enter your email address.")]
        public string UserEmail { get; set; } = string.Empty;

        /* NOTE: this implementation will change the DB tables/columns */
        // FIXME: | TODO: implement in a registration model/form
        //public string UserName { get; set; } = string.Empty;
        //public string UserPassword { get; set; } = string.Empty;

        public ICollection<Property>? Properties { get; set; }
    }
}
