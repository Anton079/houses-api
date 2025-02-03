using houses_api.Houses.Models;
using Microsoft.EntityFrameworkCore;

namespace houses_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<House> Houses { get; set; }
    }
}
