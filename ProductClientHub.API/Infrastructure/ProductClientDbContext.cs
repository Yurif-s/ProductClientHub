using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infrastructure;

public class ProductClientDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Workspace\\ProductClientHubDB\\ProductClientHub.db");
    }
}
