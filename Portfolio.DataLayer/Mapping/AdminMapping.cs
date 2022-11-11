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
    class AdminMapping : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");

            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Password).HasMaxLength(20).IsRequired();

            builder.Property(x => x.UserName).HasMaxLength(20).IsRequired();
        }
    }
}