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
                    new Realtor { RealtorId = 1, FirstName = "Timothy", LastName = "Goodsale", RealtorEmail = "tgoodsale@fakerealty.com"}
                    // new Realtor { RealtorId = 2, FirstName = "Jenny", LastName = "Goodsale", RealtorEmail = "jgoodsale@fakerealty.com"}
                );
        }
    }
}
