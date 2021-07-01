using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class CategoryAndProductConfiguration : IEntityTypeConfiguration<CategoryAndProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryAndProduct> builder)
        {
            builder.HasKey(p => new { p.CategoryId, p.ProductId });
        }
    }
}
