using Compare.DAL.Models.Commentary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Commentary
{
    public class StoreCommentConfiguration : IEntityTypeConfiguration<StoreComment>
    {
        public void Configure(EntityTypeBuilder<StoreComment> builder)
        {
            builder.Property(p => p.OrganizationId).IsRequired();
        }
    }
}
