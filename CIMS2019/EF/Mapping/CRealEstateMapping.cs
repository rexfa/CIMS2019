using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CIMS2019.EF.Domain;

namespace CIMS2019.EF.Mapping
{
    public class CRealEstateMapping : IEntityTypeConfiguration<CRealEstate>
    {
        public void Configure(EntityTypeBuilder<CRealEstate> builder)
        {
            builder.ToTable("CRealEstate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CEId).IsRequired();
            builder.Property(x => x.RealEstateAddress).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LoanTypeId).IsRequired();
            builder.Property(x => x.PropertyNatureId).IsRequired();
            builder.Property(x => x.ConstructionArea).IsRequired();
            builder.Property(x => x.RealEstateValue).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.BankName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MonthlyPayment).IsRequired();
            builder.Property(x => x.NumberOfRepayments).IsRequired();
            #region Navigation
            builder.Ignore(x => x.CustomerExpectation);
            #endregion
        }
    }
}
