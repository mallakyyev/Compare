using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class CategoryPanelAndProductConfiguration : IEntityTypeConfiguration<CategoryPanelAndProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryPanelAndProduct> builder)
        {
            builder.HasKey(p => new { p.CategoryPanelId, p.ProductId });
        }
    }
}
