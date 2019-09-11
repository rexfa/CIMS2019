using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CIMS2019.EF.Domain;

namespace CIMS2019.EF.Mapping
{
    public class CLifeInsuranceMapping : IEntityTypeConfiguration<CLifeInsurance>
    {
        public void Configure(EntityTypeBuilder<CLifeInsurance> builder)
        {
            builder.ToTable("CLifeInsurance");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CEId).IsRequired();
            builder.Property(x => x.LifeInsuranceCompany).IsRequired().HasMaxLength(200);
            builder.Property(x => x.AnnualPremium).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            #region Navigation
            builder.Ignore(x => x.CustomerExpectation);
            #endregion
        }
    }
}
