using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Mapping
{
    internal class ServiceMapping : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Decription).HasMaxLength(150).IsRequired();

            builder.Property(x => x.ClassIcon).HasMaxLength(50);
        }
    }
}
