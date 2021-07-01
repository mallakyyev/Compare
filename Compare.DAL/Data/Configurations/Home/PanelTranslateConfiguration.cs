using Compare.DAL.Models.Home;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Home
{
    public class PanelTranslateConfiguration : IEntityTypeConfiguration<PanelTranslate>
    {
        public void Configure(EntityTypeBuilder<PanelTranslate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.LanguageCulture).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.PanelId).IsRequired();
        }
    }
}
