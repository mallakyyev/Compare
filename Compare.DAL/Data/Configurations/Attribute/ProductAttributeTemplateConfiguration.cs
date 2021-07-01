using Compare.DAL.Models.Attribute;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Attribute
{
    public class ProductAttributeTemplateConfiguration : IEntityTypeConfiguration<ProductAttributeTemplate>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeTemplate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasMany(p => p.ProductAttributeTemplateTranslates).WithOne(p => p.ProductAttributeTemplate).HasForeignKey(p => p.ProductAttributeTemplateId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.ProductAttributeTemplateAndProductOptions).WithOne(p => p.ProductAttributeTemplate).HasForeignKey(p => p.ProductAttributeTemplateId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
