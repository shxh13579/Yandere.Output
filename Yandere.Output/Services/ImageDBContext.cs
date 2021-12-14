using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandere.Output.Helper;
using Yandere.Output.Models;

namespace Yandere.Output.Services
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
