using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class ProductDetailAttributeConfiguration : IEntityTypeConfiguration<ProductDetailAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductDetailAttribute> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductId).IsRequired();
            builder.HasOne(p => p.Product).WithOne(p => p.ProductDetailAttribute).HasForeignKey<Product>(p => p.ProductDetailAttributeId);
            builder.HasMany(p => p.ProductDetailAttributeTranslates).WithOne(p => p.ProductDetailAttribute).HasForeignKey(p => p.ProductDetailAttributeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
