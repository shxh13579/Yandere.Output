using Microsoft.EntityFrameworkCore;
using Yandere.Common.Helper;
using Yandere.Common.Models;

namespace Yandere.Common.Services
{
    public class ImageDBContext : DbContext
    {
        private static bool _created = false;

        private string connectionString = ConfigurationHelper.Configuration.Connection;

        public DbSet<MarkInfo> MarkInfo { get; set; }

        public DbSet<DownloadInfo> DownloadInfo { get; set; }

        public ImageDBContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MarkInfo>().ToTable("MarkInfo");
            modelBuilder.Entity<DownloadInfo>().ToTable("DownloadInfo");
        }
    }

    public static class DBContextCreator
    {
    }
}
