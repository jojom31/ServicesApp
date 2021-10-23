 using System;
using Microsoft.EntityFrameworkCore;
using ServicesApp.Core;

namespace ServicesApp.DAL
{
    public class ServicesDbContext : DbContext
    {
        public DbSet<Services> Service { get; set; }



        public ServicesDbContext() : base() { }
        public ServicesDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=;Password=;Database=ServicesApp");
        }

    }
}
