using Compare.DAL.Models.Cart;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compare.DAL.Data.Configurations.Cart
{
    public class OrderOrganizationConfiguration : IEntityTypeConfiguration<OrderOrganization>
    {
        public void Configure(EntityTypeBuilder<OrderOrganization> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.OrderId).IsRequired();
            builder.Property(p => p.OrganizationId).IsRequired();
            builder.Property(p => p.OrderStatus).IsRequired();
            builder.HasMany(p => p.Baskets).WithOne(p => p.OrderOrganization).HasForeignKey(p => p.OrderOrganizationId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
