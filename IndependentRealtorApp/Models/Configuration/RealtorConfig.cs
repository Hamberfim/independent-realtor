using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndependentRealtorApp.Models.Configuration
{
    public class RealtorConfig : IEntityTypeConfiguration<Realtor>
    {
        public void Configure(EntityTypeBuilder<Realtor> entity)
        {
            entity.HasData(
                    // only one realtor for now
                    new Realtor { RealtorId = 1, FirstName = "Timothy", LastName = "Goodsale", RealtorEmail = "tgoodsale@fakerealty.com", UserName = "Tim", RealtorPassword = "pass2" }
                );
        }
    }
}
