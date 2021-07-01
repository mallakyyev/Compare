using Compare.DAL.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Company
{
    public class OrganizationSubscriptionConfiguration : IEntityTypeConfiguration<OrganizationSubscription>
    {
        public void Configure(EntityTypeBuilder<OrganizationSubscription> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PaymentDate).IsRequired();
            builder.Property(p => p.ExpireAt).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.OrganizationId).IsRequired();
        }
    }
}
