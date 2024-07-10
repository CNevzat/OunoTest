using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class ApplicationDbContext : DbContext

{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
{

}

public DbSet<Product> Products { get; set; }
public DbSet<Category> Categories { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Category>()
    .HasMany(x => x.Products)
    .WithOne(x => x.Category)
    .HasForeignKey(x => x.CategoryId);
}
}
