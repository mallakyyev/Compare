using Compare.DAL.Models.Home;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Home
{
    public class PanelConfiguration : IEntityTypeConfiguration<Panel>
    {
        public void Configure(EntityTypeBuilder<Panel> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DisplayOrder).IsRequired();
            builder.Property(p => p.IsPublish).IsRequired();
            builder.HasMany(p => p.PanelTranslates).WithOne(p => p.Panel).HasForeignKey(k => k.PanelId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.PanelAndProducts).WithOne(p => p.Panel).HasForeignKey(k => k.PanelId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
