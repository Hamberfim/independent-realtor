using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndependentRealtorApp.Models.Configuration
{
    public class PropertyUserConfig : IEntityTypeConfiguration<PropertyUser>
    {
        public void Configure(EntityTypeBuilder<PropertyUser> entity) 
        { 
            entity.HasKey(pu => new { pu.PropertyId, pu.UserId });

            entity.HasOne(pu => pu.Property)
                .WithMany(p => p.PropertyUsers)
                .HasForeignKey(pu => pu.PropertyId);

            entity.HasOne(pu => pu.User)
                .WithMany(u => u.PropertyUsers)
                .HasForeignKey(pu => pu.UserId);

            entity.HasData(
                new PropertyUser { PropertyId = 1, UserId = 1 },
                new PropertyUser { PropertyId = 1, UserId = 2 },
                new PropertyUser { PropertyId = 2, UserId = 1 },
                new PropertyUser { PropertyId = 2, UserId = 3 },
                new PropertyUser { PropertyId = 3, UserId = 4 },
                new PropertyUser { PropertyId = 3, UserId = 7 },
                new PropertyUser { PropertyId = 4, UserId = 5 },
                new PropertyUser { PropertyId = 4, UserId = 6 },
                new PropertyUser { PropertyId = 5, UserId = 5 },
                new PropertyUser { PropertyId = 5, UserId = 3 },
                new PropertyUser { PropertyId = 6, UserId = 2 },
                new PropertyUser { PropertyId = 6, UserId = 4 },
                new PropertyUser { PropertyId = 7, UserId = 1 },
                new PropertyUser { PropertyId = 7, UserId = 7 }
                );
        }
    }
}
