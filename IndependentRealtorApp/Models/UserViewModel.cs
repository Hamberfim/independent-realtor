using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace IndependentRealtorApp.Models
{
    public class UserViewModel
    {
        public IEnumerable<PublicUser> Users { get; set; } = null!;


        //public IEnumerable<IdentityRole> Roles { get; set; } = null!;
        public IEnumerable<ApplicationRole> Roles { get; set; } = null!;
    }
}
