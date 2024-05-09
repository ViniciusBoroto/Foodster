using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    DbSet<Item> Items { get; set; }
}
