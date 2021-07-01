using Compare.DAL.Models.Info;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Info
{
    public class InformationTranslateConfiguration : IEntityTypeConfiguration<InformationTranslate>
    {
        public void Configure(EntityTypeBuilder<InformationTranslate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.LanguageCulture).IsRequired();
            builder.Property(p => p.Address).IsRequired(false);
            builder.Property(p => p.Description).IsRequired(false);
            builder.Property(p => p.InformationId).IsRequired();
        }
    }
}
