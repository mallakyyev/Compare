using Compare.DAL.Models.Company;
using Compare.DAL.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.User
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(p => p.FirstName).IsRequired(false);
            builder.Property(p => p.LastName).IsRequired(false);
            builder.Property(p => p.FullName).IsRequired(false);
            builder.Property(p => p.OrganizationId).IsRequired(false);
            builder.HasOne(p => p.Organization).WithOne(p => p.ApplicationUser).HasForeignKey<Organization>(p => p.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Comments).WithOne(p => p.ApplicationUser).HasForeignKey(p => p.ApplicationUserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Bookmarks).WithOne(p => p.ApplicationUser).HasForeignKey(p => p.ApplicationUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Orders).WithOne(p => p.ApplicationUser).HasForeignKey(p => p.ApplicationUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Baskets).WithOne(p => p.ApplicationUser).HasForeignKey(p => p.ApplicationUserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
