using ApplicationCore.Domain;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Audit>Audits { get; set; }
        public DbSet<Cabinet_Audit> Cabinets { get; set;}
        public DbSet<DetailsAudit> Details { get; set; }
        public DbSet<Entreprise> Entreprisees { get; set;}
        public DbSet<Equipement> Equipements { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=AuditRafrafAdam;
                Integrated Security=true;
                MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cabinet_Audit>().HasKey(c => c.Adresse);
            modelBuilder.ApplyConfiguration(new AuditConfig());
            modelBuilder.ApplyConfiguration(new DetailAuditConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
