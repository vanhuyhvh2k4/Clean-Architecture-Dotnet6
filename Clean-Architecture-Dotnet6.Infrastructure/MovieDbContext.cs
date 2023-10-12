
using Clean_Architecture_Dotnet6.Domain;
using Microsoft.EntityFrameworkCore;

namespace Clean_Architecture_Dotnet6.Infrastructure
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
