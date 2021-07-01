using Compare.DAL.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Company
{
    public class OrganizationApiConfiguration : IEntityTypeConfiguration<OrganizationApi>
    {
        public void Configure(EntityTypeBuilder<OrganizationApi> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired(false);
            builder.Property(p => p.OrganizationId).IsRequired();
            builder.Property(p => p.UrlApi).IsRequired();
            builder.HasMany(p => p.CategoriesAndOrganizationApis).WithOne(p => p.OrganizationApi).HasForeignKey(p => p.OrganizationApiId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
