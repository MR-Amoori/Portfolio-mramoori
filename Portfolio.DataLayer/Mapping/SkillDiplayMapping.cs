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
    class SkillDiplayMapping : IEntityTypeConfiguration<SkillDisplay>
    {
        public void Configure(EntityTypeBuilder<SkillDisplay> builder)
        {
            builder.ToTable("SkillsDisplay");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        }
    }
}
