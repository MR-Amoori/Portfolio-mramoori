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
    internal class SkillMapping : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skills");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Percentage).HasMaxLength(100).IsRequired();

            //  builder.HasOne(x => x.Personal).WithMany(x => x.Skills).HasForeignKey(x => x.PersonalId);
        }
    }
}