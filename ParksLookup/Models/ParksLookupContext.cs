using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Park> Parks { get; set; }

    public ParksLookupContext(DbContextOptions<ParksLookupContext> options) : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
              .HasData(
                new Park 
                { 
                  ParkId = 1, 
                  Name = "North Cascades National Park", 
                  Location = "Marblemount, WA", 
                  Description = "Less than three hours from Seattle, an alpine landscape beckons. Discover communities of life adapted to moisture in the west and recurring fire in the east. Explore jagged peaks crowned by more than 300 glaciers. Listen to cascading waters in forested valleys. Witness a landscape sensitive to the Earth's changing climate.", 
                  ParkType = "National Park" 
                },
                new Park 
                { 
                  ParkId = 2, 
                  Name = "Olympic National Park", 
                  Location = "Port Angeles, WA", 
                  Description = "With its incredible range of precipitation and elevation, diversity is the hallmark of Olympic National Park. Encompassing nearly a million acres, the park protects a vast wilderness, thousands of years of human history, and several distinctly different ecosystems, including glacier-capped mountains, old-growth temperate rain forests, and over 70 miles of wild coastline.", 
                  ParkType = "National Park" 
                },
                new Park 
                {
                  ParkId = 3,
                  Name = "Mount Rainier National Park",
                  Location = "Ashford, WA.",
                  Description = "Ascending to 14,410 feet above sea level, Mount Rainier stands as an icon in the Washington landscape. An active volcano, Mount Rainier is the most glaciated peak in the contiguous U.S.A., spawning five major rivers. Subalpine wildflower meadows ring the icy volcano while ancient forest cloaks Mount Rainier's lower slopes.",
                  ParkType = "National Park"
                }
              );
        }
    }
}