using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksLookupContext(DbContextOptions<ParksLookupContext> options) : base(options)
    {
    
    }
  }
}