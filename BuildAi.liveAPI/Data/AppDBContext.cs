using BuildAi.liveAPI.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BuildAi.liveAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }

}
