using Compare.DAL.Models.Attribute;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Attribute
{
    public class ProductAttributeTemplateAndProductOptionConfiguration : IEntityTypeConfiguration<ProductAttributeTemplateAndProductOption>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeTemplateAndProductOption> builder)
        {
            builder.HasKey(p => new { p.ProductAttributeTemplateId, p.ProductOptionId });
        }
    }
}
