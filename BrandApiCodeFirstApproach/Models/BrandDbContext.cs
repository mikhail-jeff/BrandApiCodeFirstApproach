using Microsoft.EntityFrameworkCore;

namespace BrandApiCodeFirstApproach.Models
{
    public class BrandDbContext : DbContext
    {
        public BrandDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
    }
}
