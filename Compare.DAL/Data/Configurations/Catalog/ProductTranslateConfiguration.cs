using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class ProductTranslateConfiguration : IEntityTypeConfiguration<ProductTranslate>
    {
        public void Configure(EntityTypeBuilder<ProductTranslate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.ShortDescription).IsRequired(false);
            builder.Property(p => p.FullDescription).IsRequired(false);
            builder.Property(p => p.MetaTitle).IsRequired(false);
            builder.Property(p => p.MetaDescription).IsRequired(false);
            builder.Property(p => p.LanguageCulture).IsRequired();
            builder.Property(p => p.ProductId).IsRequired();
        }
    }
}
