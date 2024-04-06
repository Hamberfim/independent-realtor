using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndependentRealtorApp.Models.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            // public users table
            entity.HasData(
                new User { UserId = 1, FirstName = "Sam", LastName = "Smith", UserEmail = "ssmith@fakeworld.net" },
                new User { UserId = 2, FirstName = "Linda", LastName = "Beltcher", UserEmail = "lbeltcher@fakeworld.net" },
                new User { UserId = 3, FirstName = "Bob", LastName = "Beltcher", UserEmail = "bbeltcher@fakeworld.net" },
                new User { UserId = 4, FirstName = "Kathy", LastName = "Klien", UserEmail = "kklien@fakeworld.net" },
                new User { UserId = 5, FirstName = "Billy", LastName = "Williams", UserEmail = "bwilliams@fakeworld.net" },
                new User { UserId = 6, FirstName = "Sarah", LastName = "Seashell", UserEmail = "sseashell@fakeworld.net" },
                new User { UserId = 7, FirstName = "Steven", LastName = "Klien", UserEmail = "sklien@fakeworld.net" }
                );
        }
    }
}
