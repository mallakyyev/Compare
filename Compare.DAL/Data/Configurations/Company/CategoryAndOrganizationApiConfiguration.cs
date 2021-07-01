using Compare.DAL.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Company
{
    public class CategoryAndOrganizationApiConfiguration : IEntityTypeConfiguration<CategoryAndOrganizationApi>
    {
        public void Configure(EntityTypeBuilder<CategoryAndOrganizationApi> builder)
        {
            builder.HasKey(p => new { p.CategoryId, p.OrganizationApiId });
        }
    }
}
