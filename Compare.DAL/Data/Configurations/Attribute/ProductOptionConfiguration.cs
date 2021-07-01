using Compare.DAL.Models.Attribute;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Attribute
{
    public class ProductOptionConfiguration : IEntityTypeConfiguration<ProductOption>
    {
        public void Configure(EntityTypeBuilder<ProductOption> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasMany(p => p.ProductOptionTranslates).WithOne(p => p.ProductOption).HasForeignKey(p => p.ProductOptionId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.ProductAttributeTemplateAndProductOptions).WithOne(p => p.ProductOption).HasForeignKey(p => p.ProductOptionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
