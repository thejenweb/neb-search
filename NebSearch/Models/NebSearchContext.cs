using Microsoft.EntityFrameworkCore;

namespace NebSearch.Models
{
  public class NebSearchContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public NebSearchContext(DbContextOptions options) : base(options) { }
  }
}