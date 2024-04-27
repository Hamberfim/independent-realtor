using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace IndependentRealtorApp.Models.Configuration
{
    public class ConfigureIdentity
    {
        public static async Task CreateAdminUserAsync(IServiceProvider provider)
        {
            var roleManager =
                provider.GetRequiredService<RoleManager<ApplicationRole>>();
            var userManager =
                provider.GetRequiredService<UserManager<PublicUser>>();

            string username = "admin";
            string password = "Password321";
            string roleName = "Admin";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                PublicUser user = new PublicUser { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

    }
}
