using Compare.DAL.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Company
{
    public class OrganizationProductConfiguration : IEntityTypeConfiguration<OrganizationProduct>
    {
        public void Configure(EntityTypeBuilder<OrganizationProduct> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.OrganizationProductId).IsRequired(false);
            builder.Property(p => p.OrganizationProductUrl).IsRequired(false);
            builder.Property(p => p.OrganizationId).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.InStock).IsRequired();
            builder.Property(p => p.OfficialDealer).IsRequired();
            builder.HasMany(p => p.Baskets).WithOne(p => p.OrganizationProduct).HasForeignKey(p => p.OrganizationProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
