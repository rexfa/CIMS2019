using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CIMS2019.EF.Domain;

namespace CIMS2019.EF.Mapping
{
    public class CCreditCardCarLoanMapping : IEntityTypeConfiguration<CCreditCardCarLoan>
    {
        public void Configure(EntityTypeBuilder<CCreditCardCarLoan> builder)
        {
            builder.ToTable("CCreditCardCarLoan");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CustomerExpectationId).IsRequired();
            builder.Property(x => x.MonthlyAmount).IsRequired();
            builder.Property(x => x.NumberOfRepaymentsCC).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            #region Navigation
            builder.Ignore(x => x.CustomerExpectation);
            #endregion
        }
    }
}
