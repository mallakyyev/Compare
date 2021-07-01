using Compare.DAL.Models.Home;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Home
{
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.Link).IsRequired(false);
            builder.Property(p => p.DisplayOrder).IsRequired();
            builder.Property(p => p.IsPublish).IsRequired();
            builder.HasMany(p => p.BannerTranslates).WithOne(p => p.Banner).HasForeignKey(k => k.BannerId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
