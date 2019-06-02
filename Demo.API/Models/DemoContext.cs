using Microsoft.EntityFrameworkCore;

namespace Demo.API.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }

        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }
    }
}
