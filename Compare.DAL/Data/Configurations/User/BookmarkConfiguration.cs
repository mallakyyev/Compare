using Compare.DAL.Models.Bookmarks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Data.Configurations.User
{
    public class BookmarkConfiguration : IEntityTypeConfiguration<Bookmark>
    {
        public void Configure(EntityTypeBuilder<Bookmark> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ApplicationUserId).IsRequired();
            builder.Property(p => p.ProductId).IsRequired();
        }
    }
}
