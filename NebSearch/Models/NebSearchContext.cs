using Microsoft.EntityFrameworkCore;

namespace NebSearch.Models
{
  public class NebSearchContext : DbContext
  {
    public DbSet<Image> Images { get; set; }

    public NebSearchContext(DbContextOptions options) : base(options) { }
  }
}