using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CIMS2019.EF.Domain;

namespace CIMS2019.EF.Mapping
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IDNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.HasIndex(x => x.LoginName).IsUnique();
            builder.Property(x => x.LoginName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CPassword).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Salt).IsRequired().HasDefaultValue("").HasMaxLength(10);
            builder.Property(x => x.Avatar).HasMaxLength(200);
            builder.Property(x => x.Fever).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CustomerName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            #region Navigation
            builder.Ignore(x => x.CustomerExpectations);
            builder.HasMany(x => x.CustomerExpectations).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
