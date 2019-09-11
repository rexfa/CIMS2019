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
            builder.Property(x => x.Address).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LoanTypeId).IsRequired();
            builder.Property(x => x.PropertyNatureId).IsRequired();
            builder.Property(x => x.Value).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            #region Navigation
            builder.Ignore(x => x.CustomerExpectation);
            #endregion
        }
    }
}
