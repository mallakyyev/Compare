using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class CategoryTranslateConfiguration : IEntityTypeConfiguration<CategoryTranslate>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.MetaTitle).IsRequired(false);
            builder.Property(p => p.MetaDescription).IsRequired(false);
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.LanguageCulture).IsRequired();
        }
    }
}
