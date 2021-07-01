using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Image).IsRequired(false);
            builder.Property(p => p.Published).IsRequired();
            builder.Property(p => p.ManufactureId).IsRequired();
            builder.Property(p => p.ProductDetailAttributeId).IsRequired(false);
            builder.Property(p => p.MinPrice).IsRequired(false);
            builder.Property(p => p.MaxPrice).IsRequired(false);
            builder.Property(p => p.CountOffers).IsRequired(false);
            builder.HasOne(p => p.ProductDetailAttribute).WithOne(p => p.Product).HasForeignKey<ProductDetailAttribute>(p => p.ProductId);
            builder.HasMany(p => p.ProductTranslates).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.CategoriesAndProducts).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.OrganizationProducts).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.ProductMedias).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.PanelAndProducts).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.CategoriesAndProducts).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.ProductComments).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Bookmarks).WithOne(p => p.Product).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
