using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class CategoryPanelConfiguration : IEntityTypeConfiguration<CategoryPanel>
    {
        public void Configure(EntityTypeBuilder<CategoryPanel> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.DisplayOrder).IsRequired();
            builder.Property(p => p.IsPublish).IsRequired();
            builder.HasMany(p => p.CategoryPanelTranslates).WithOne(p => p.CategoryPanel).HasForeignKey(k => k.CategoryPanelId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.CategoryPanelAndProducts).WithOne(p => p.CategoryPanel).HasForeignKey(k => k.CategoryPanelId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
