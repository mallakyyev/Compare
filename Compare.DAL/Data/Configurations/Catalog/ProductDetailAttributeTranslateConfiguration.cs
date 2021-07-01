using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class ProductDetailAttributeTranslateConfiguration : IEntityTypeConfiguration<ProductDetailAttributeTranslate>
    {
        public void Configure(EntityTypeBuilder<ProductDetailAttributeTranslate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Value).IsRequired();
            builder.Property(p => p.LanguageCulture).IsRequired();
            builder.Property(p => p.ProductDetailAttributeId).IsRequired();
        }
    }
}
