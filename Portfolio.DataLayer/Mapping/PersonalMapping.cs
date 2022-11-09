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
    class PersonalMapping : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.ToTable("Personal");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasMaxLength(20).IsRequired().HasDefaultValue("محمدرضا");

            builder.Property(x => x.LastName).HasMaxLength(20).IsRequired().HasDefaultValue("عموری");

            builder.Property(x => x.Email).HasMaxLength(70).IsRequired().HasDefaultValue("mohamad.reza.amoori99@gmail.com");

            builder.Property(x => x.Address).HasMaxLength(250).IsRequired().HasDefaultValue("خرمشهر");

            builder.Property(x => x.Freelancer).HasMaxLength(15).IsRequired().HasDefaultValue("آزاد");

            builder.Property(x => x.Github).HasMaxLength(100).IsRequired().HasDefaultValue("MR-Amoori");

            builder.Property(x => x.Instagram).HasMaxLength(100).IsRequired().HasDefaultValue("MR__Amoori");

            builder.Property(x => x.Languages).HasMaxLength(20).IsRequired().HasDefaultValue("فارسی");

            builder.Property(x => x.Linkedin).HasMaxLength(100).IsRequired().HasDefaultValue("mohamadreza-amoori-967ab8224");

            builder.Property(x => x.Mobile).HasMaxLength(15).IsRequired().HasDefaultValue("+989035170373");

            builder.Property(x => x.Twitter).HasMaxLength(100).IsRequired().HasDefaultValue("mr__amoori");


        }
    }
}