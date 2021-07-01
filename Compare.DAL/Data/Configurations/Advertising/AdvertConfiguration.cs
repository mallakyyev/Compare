using Compare.DAL.Models.Advertising;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Advertising
{
    public class AdvertConfiguration : IEntityTypeConfiguration<Advert>
    {
        public void Configure(EntityTypeBuilder<Advert> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.AdvertPlaceStatus).IsRequired();
            builder.Property(p => p.PagePlaceStatus).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired(false);
            builder.Property(p => p.DateStart).IsRequired();
            builder.Property(p => p.DateEnd).IsRequired();
            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.Link).IsRequired(false);
            builder.Property(p => p.DisplayOrder).IsRequired();
            builder.Property(p => p.IsPublish).IsRequired();
            builder.HasMany(p => p.AdvertTranslates).WithOne(p => p.Advert).HasForeignKey(p => p.AdvertId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
