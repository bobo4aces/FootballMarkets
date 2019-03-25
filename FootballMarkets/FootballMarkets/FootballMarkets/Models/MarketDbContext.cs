using FootballMarkets.Models.Configurations;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMarkets.Models
{
    public class MarketDbContext : DbContext
    {
        public DbSet<ExactScore> ExactScores { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Winner> Winners { get; set; }
        public MarketDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public MarketDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=FootballMarkets;Integrated Security=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExactScoreConfig());
            modelBuilder.ApplyConfiguration(new GameConfig());
            modelBuilder.ApplyConfiguration(new WinnerConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
