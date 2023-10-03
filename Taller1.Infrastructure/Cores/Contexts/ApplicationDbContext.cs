using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1.Domain.Admins.Models;
using Taller1.Infrastructure.Admins.Configurations;

namespace Taller1.Infrastructure.Cores.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbConnection"));
        }

        #region "DBSet"
        public DbSet<Miningconcession> Miningconcessions { get; set; }
        public DbSet<Paypenalityvalidityformated> Paypenalityvalidityformateds { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MiningconcessionConfiguration());
            modelBuilder.ApplyConfiguration(new PaypenalityvalidityformatedConfiguration());
        }
    }
}
