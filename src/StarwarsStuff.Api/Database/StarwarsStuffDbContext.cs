using Microsoft.EntityFrameworkCore;
using StarwarsStuff.Api.Models;

namespace StarwarsStuff.Api.Database
{
    public class StarwarsStuffDbContext : DbContext
    {
        public StarwarsStuffDbContext (DbContextOptions<StarwarsStuffDbContext> options)
            : base(options)
        {
        }
        public DbSet<Planet> Planets {get;set;}
    }
    
}