
using Microsoft.EntityFrameworkCore;
namespace CrudOperationsInNetCore.Models
{
    public class BrandContext : DbContext 
    {
        public BrandContext(DbContextOptions<BrandContext> options) :base(options) { 
        
        }
       public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasKey(p => p.id);
        }
        public class Class
        {
            public int ID { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public string? Directions { get; set; }
        }
    }
}