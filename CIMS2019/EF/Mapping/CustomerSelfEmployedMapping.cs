using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CIMS2019.EF.Domain;


namespace CIMS2019.EF.Mapping
{
    public class CustomerSelfEmployedMapping : IEntityTypeConfiguration<CustomerSelfEmployed>
    {
        public void Configure(EntityTypeBuilder<CustomerSelfEmployed> builder)
        {
            builder.ToTable("CustomerSelfEmployed");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CEId).IsRequired();
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.AnnualVATInvoiceAmount).IsRequired();
            builder.Property(x => x.AnnualTaxAmount).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            #region Navigation
            builder.Ignore(x => x.CustomerExpectation);
            #endregion
        }
    }
}
