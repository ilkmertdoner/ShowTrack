using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShowTrack.Entity;

namespace ShowTrack.DataAccess
{
    internal class ShowTrackContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<MailLog> MailLog { get; set; }
        public DbSet<WatchList> WatchList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var settings = ConfigurationManager.ConnectionStrings["ShowTrackConnection"];
                optionsBuilder.UseSqlServer(settings.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<MailLog>().ToTable("MailLog");
            modelBuilder.Entity<WatchList>().ToTable("Watchlist");

            base.OnModelCreating(modelBuilder);
        }
    }
}
