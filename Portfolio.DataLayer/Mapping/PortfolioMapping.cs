using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portfolio.DataLayer.Mapping
{
    class PortfolioMapping : IEntityTypeConfiguration<Models.Portfolio>
    {
        public void Configure(EntityTypeBuilder<Models.Portfolio> builder)
        {
            builder.ToTable("Portfolios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Link).HasMaxLength(100).IsRequired();

            builder.Property(x => x.ImagePath).HasMaxLength(100).IsRequired();
        }
    }
}
