using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Mapping
{
    class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(80).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Message).HasMaxLength(1500).IsRequired();

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        }
    }
}