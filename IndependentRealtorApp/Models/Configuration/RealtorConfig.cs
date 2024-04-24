using IndependentRealtorApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IndependentRealtorApp.Models.Configuration
{
    public class RealtorConfig : IEntityTypeConfiguration<Realtor>
    {
        public void Configure(EntityTypeBuilder<Realtor> entity)
        {
            entity.HasKey(r => r.Id).HasName("PK_Id");
            entity.HasData(
                    // only one realtor for now
                    new Realtor { FirstName = "Timothy", LastName = "Goodsale", RealtorEmail = "tgoodsale@fakerealty.com", UserName = "Tim", RealtorPassword = "pass2" }
                );
        }
    }
}
