using Compare.DAL.Models.Info;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Info
{
    public class InformationConfiguration : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.InformationStatus).IsRequired(false);
            builder.Property(p => p.Phone).IsRequired(false);
            builder.Property(p => p.Email).IsRequired(false);
            builder.HasMany(p => p.InformationTranslates).WithOne(p => p.Information).HasForeignKey(p => p.InformationId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
