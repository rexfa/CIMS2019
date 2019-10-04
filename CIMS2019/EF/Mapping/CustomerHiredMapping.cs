using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CIMS2019.EF.Domain;


namespace CIMS2019.EF.Mapping
{
    public class CustomerHiredMapping : IEntityTypeConfiguration<CustomerHired>
    {
        public void Configure(EntityTypeBuilder<CustomerHired> builder)
        {
            builder.ToTable("CustomerHired");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CustomerExpectationId).IsRequired();
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SalaryAfterTax).IsRequired();
            builder.Property(x => x.HavingSIHF).IsRequired();
            builder.Property(x => x.SocialInsuranceBase).IsRequired();
            builder.Property(x => x.HousingFundBase).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            #region Navigation
            builder.Ignore(x => x.CustomerExpectation);
            //builder.HasOne(ch => ch.CustomerExpectation).WithMany(ce => ce.CustomerHireds).OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
