using System.ComponentModel.DataAnnotations;

namespace IndependentRealtorApp.Models.DomainModels
{
    public class UserService : IUser
    {
        private readonly RealtorContext _context;

        public UserService(RealtorContext ctx)
        {
            _context = ctx;
        }

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

        public List<User> GetUsers()
        {
            return _context.publicUsers.ToList();
        }

    }
}
