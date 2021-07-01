using Compare.DAL.Models.Attribute;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Attribute
{
    public class ProductAttributeTemplateTranslateConfiguration : IEntityTypeConfiguration<ProductAttributeTemplateTranslate>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeTemplateTranslate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.LanguageCulture).IsRequired();
            builder.Property(p => p.ProductAttributeTemplateId).IsRequired();
        }
    }
}
