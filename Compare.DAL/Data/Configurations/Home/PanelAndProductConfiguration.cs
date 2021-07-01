using Compare.DAL.Models.Home;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.Home
{
    public class PanelAndProductConfiguration : IEntityTypeConfiguration<PanelAndProduct>
    {
        public void Configure(EntityTypeBuilder<PanelAndProduct> builder)
        {
            builder.HasKey(p => new { p.PanelId, p.ProductId });
        }
    }
}
