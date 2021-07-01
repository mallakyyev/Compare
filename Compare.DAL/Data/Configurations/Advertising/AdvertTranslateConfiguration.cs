using Compare.DAL.Models.Advertising;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Advertising
{
    public class AdvertTranslateConfiguration : IEntityTypeConfiguration<AdvertTranslate>
    {
        public void Configure(EntityTypeBuilder<AdvertTranslate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.LanguageCulture).IsRequired();
            builder.Property(p => p.AdvertId).IsRequired();
        }
    }
}
