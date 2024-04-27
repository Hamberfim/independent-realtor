using Microsoft.AspNetCore.Identity;

namespace IndependentRealtorApp.Models.DataLayer
{
    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }

        // inherits all properties from IdentityRole
    }
}
