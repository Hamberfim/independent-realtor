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
                new User { UserId = 1, FirstName = "Sam", LastName = "Smith", UserEmail = "ssmith@fakeworld.net", UserName = "Sam", UserPassword = "pass1" },
                new User { UserId = 2, FirstName = "Linda", LastName = "Beltcher", UserEmail = "lbeltcher@fakeworld.net", UserName = "Linda", UserPassword = "pass1" },
                new User { UserId = 3, FirstName = "Bob", LastName = "Beltcher", UserEmail = "bbeltcher@fakeworld.net", UserName = "Bob", UserPassword = "pass1" },
                new User { UserId = 4, FirstName = "Kathy", LastName = "Klien", UserEmail = "kklien@fakeworld.net", UserName = "Kathy", UserPassword = "pass1" },
                new User { UserId = 5, FirstName = "Billy", LastName = "Williams", UserEmail = "bwilliams@fakeworld.net", UserName = "Billy", UserPassword = "pass1" },
                new User { UserId = 6, FirstName = "Sarah", LastName = "Seashell", UserEmail = "sseashell@fakeworld.net", UserName = "Sarah", UserPassword = "pass1" },
                new User { UserId = 7, FirstName = "Steven", LastName = "Klien", UserEmail = "sklien@fakeworld.net", UserName = "Steven", UserPassword = "pass1" }
                );
        }
    }
}
