using Compare.DAL.Models.Cart;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compare.DAL.Data.Configurations.Cart
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.ApplicationUserId).IsRequired();
            builder.Property(p => p.OrganizationProductId).IsRequired();
            builder.Property(p => p.BasketStatus).IsRequired();
            builder.Property(p => p.OrderOrganizationId).IsRequired(false);
        }
    }
}
