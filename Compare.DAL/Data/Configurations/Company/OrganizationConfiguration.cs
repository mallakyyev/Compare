using Compare.DAL.Models.Company;
using Compare.DAL.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Company
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Logo).IsRequired(false);
            builder.Property(p => p.Description).IsRequired(false);
            builder.Property(p => p.Address).IsRequired(false);
            builder.Property(p => p.Email).IsRequired(false);
            builder.Property(p => p.Phone).IsRequired(false);
            builder.Property(p => p.Site).IsRequired(false);
            builder.Property(p => p.ApplicationUserId).IsRequired(false);
            builder.HasOne(p => p.ApplicationUser).WithOne(p => p.Organization).HasForeignKey<ApplicationUser>(p => p.OrganizationId);
            builder.HasMany(p => p.OrganizationProducts).WithOne(p => p.Organization).HasForeignKey(p => p.OrganizationId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.OrganizationApis).WithOne(p => p.Organization).HasForeignKey(p => p.OrganizationId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.OrganizationSubscriptions).WithOne(p => p.Organization).HasForeignKey(p => p.OrganizationId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.StoreComments).WithOne(p => p.Organization).HasForeignKey(p => p.OrganizationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
