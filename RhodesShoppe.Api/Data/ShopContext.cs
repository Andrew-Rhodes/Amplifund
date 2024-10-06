using Microsoft.EntityFrameworkCore;
using RhodesShoppe.Api.Models;

public class ShopContext : DbContext
{
    public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<GuitarRepair> GuitarRepairs { get; set; }
}