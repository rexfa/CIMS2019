using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CIMS2019.EF.Domain;

namespace CIMS2019.EF.Mapping
{
    public class CustomerExpectationMapping : IEntityTypeConfiguration<CustomerExpectation>
    {
        public void Configure(EntityTypeBuilder<CustomerExpectation> builder)
        {
            builder.ToTable("CustomerExpectation");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.CustomerTypeId).IsRequired();
            builder.Property(x => x.WorkingAddress).IsRequired().HasMaxLength(300);
            builder.Property(x => x.ExpectedLoanAmount).IsRequired();
            builder.Property(x => x.ExpectedLoanTime).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();


            #region Navigation
            builder.Ignore(x => x.Customer);
            builder.Ignore(x => x.CCreditCardCarLoans);
            builder.HasMany(x => x.CCreditCardCarLoans).WithOne(x => x.CustomerExpectation).HasForeignKey(x => x.CEId).OnDelete(DeleteBehavior.Restrict);
            builder.Ignore(x => x.CLifeInsurances);
            builder.HasMany(x => x.CLifeInsurances).WithOne(x => x.CustomerExpectation).HasForeignKey(x => x.CEId).OnDelete(DeleteBehavior.Restrict);
            builder.Ignore(x => x.CRealEstates);
            builder.HasMany(x => x.CRealEstates).WithOne(x => x.CustomerExpectation).HasForeignKey(x => x.CEId).OnDelete(DeleteBehavior.Restrict);
            builder.Ignore(x => x.CustomerHireds);
            builder.HasMany(x => x.CustomerHireds).WithOne(x => x.CustomerExpectation).HasForeignKey(x => x.CEId).OnDelete(DeleteBehavior.Restrict);
            builder.Ignore(x => x.CustomerSelfEmployeds);
            builder.HasMany(x => x.CustomerSelfEmployeds).WithOne(x => x.CustomerExpectation).HasForeignKey(x => x.CEId).OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
