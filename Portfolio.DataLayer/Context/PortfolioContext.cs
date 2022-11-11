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

        public DbSet<Personal> Personal { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Models.Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<SkillDisplay> SkillsDisplay { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(PortfolioMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            //  modelBuilder.ApplyConfiguration(new PersonalMapping());
            //  modelBuilder.ApplyConfiguration(new ServiceMapping());
            //  modelBuilder.ApplyConfiguration(new SkillMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}