using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DisplayOrder).IsRequired();
            builder.Property(p => p.Published).IsRequired();
            builder.Property(p => p.ParentCategoryId).IsRequired(false);
            builder.HasOne(p => p.ParentCategory).WithMany(p => p.Categories).HasForeignKey(p => p.ParentCategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.CategoryTranslates).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.CategoriesAndProducts).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.CategoriesAndOrganizationApis).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.OrganizationSubscriptions).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Adverts).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.CategoryPanels).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
