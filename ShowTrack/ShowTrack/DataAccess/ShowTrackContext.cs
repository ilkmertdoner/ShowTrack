using System;
using System.Collections.Generic;
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
                // Update the connection string as per your local database configuration
                optionsBuilder.UseSqlServer("ENTER YOUR LOCAL DATABASE NAME;Initial Catalog=ShowTrack;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
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
