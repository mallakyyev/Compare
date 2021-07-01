using Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Catalog
{
    public class ManufactureConfiguration : IEntityTypeConfiguration<Manufacture>
    {
        public void Configure(EntityTypeBuilder<Manufacture> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.DisplayOrder).IsRequired();
            builder.Property(p => p.Image).IsRequired(false);
            builder.HasMany(p => p.Products).WithOne(p => p.Manufacture).HasForeignKey(p => p.ManufactureId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
