using Compare.DAL.Models.Cart;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compare.DAL.Data.Configurations.Cart
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.OrderNumber).IsRequired();
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired(false);
            builder.Property(p => p.Email).IsRequired(false);
            builder.Property(p => p.Phone).IsRequired();
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.Note).IsRequired(false);
            builder.Property(p => p.OrderDate).IsRequired();
            builder.Property(p => p.ApplicationUserId).IsRequired();
            builder.HasMany(p => p.OrderOrganizations).WithOne(p => p.Order).HasForeignKey(p => p.OrderId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
