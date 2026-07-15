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
    public class BusinessLicenseMapping : IEntityTypeConfiguration<BusinessLicense>
    {
        public void Configure(EntityTypeBuilder<BusinessLicense> builder)
        {
            builder.ToTable("BusinessLicenses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();

            builder.Property(x => x.ImagePath).HasMaxLength(500).IsRequired();

            builder.Property(x => x.VerificationLink).HasMaxLength(500).IsRequired();
        }
    }
}
