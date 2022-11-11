using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Mapping
{
   public class BlogMapping : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();

            builder.Property(x => x.CreateDate).IsRequired();
          
            builder.Property(x => x.Description).HasMaxLength(400).IsRequired();
          
            builder.Property(x => x.ImagePath).HasMaxLength(250).IsRequired();
          
            builder.Property(x => x.Link).HasMaxLength(250).IsRequired();

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
