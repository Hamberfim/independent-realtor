using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IndependentRealtorApp.Models.DomainModels
{
    public class Realtor
    {
        // public Realtor() => Properties = new HashSet<Property>();

        public int Id { get; set; }

        // public string RealtorId { get; set; } = string.Empty;

        [Display(Name = "First Name")]
        [StringLength(125, ErrorMessage = "First name must be 125 characters or less")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(125, ErrorMessage = "Last name must be 125 characters or less")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";  // read-only property

        [Display(Name = "Realtor Email")]
        [Required(ErrorMessage = "Please enter your email address.")]
        public string RealtorEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter user name.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public string RealtorPassword { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Please enter to confirm your password.")]
        //[DataType(DataType.Password)]
        //[Compare("Password")]
        //[NotMapped]
        //public string ConfirmPassword { get; set; } = string.Empty;

        public ICollection<Property>? Properties { get; set; }
    }
}
