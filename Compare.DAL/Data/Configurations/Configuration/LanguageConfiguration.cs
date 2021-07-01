using Compare.DAL.Models.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(p => p.Culture);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.LanguageCode).IsRequired();
            builder.Property(p => p.Published).IsRequired();
        }
    }
}
