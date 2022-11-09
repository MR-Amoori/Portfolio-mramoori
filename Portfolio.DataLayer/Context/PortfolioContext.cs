using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio.DataLayer.Mapping;
using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Context
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }

        DbSet<Personal> Personal { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonalMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
